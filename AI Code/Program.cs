using System;
using System.IO;
using OpenCvSharp;

class Program
{
	static void Main(string[] args)
	{
		string inputPath = "22042025112138.tif";      // Đường dẫn ảnh gốc
		string outputFolder = "cropped_tif"; // Thư mục chứa ảnh crop
		Directory.CreateDirectory(outputFolder);

		// Đọc ảnh
		Mat src = Cv2.ImRead(inputPath, ImreadModes.Color);
		if (src.Empty())
		{
			Console.WriteLine("Không đọc được ảnh.");
			return;
		}

		// Chuyển sang grayscale và làm mượt
		Mat gray = new Mat();
		Cv2.CvtColor(src, gray, ColorConversionCodes.BGR2GRAY);
		Mat blurred = new Mat();
		Cv2.GaussianBlur(gray, blurred, new Size(5, 5), 0);

		// Nhị phân hóa ảnh
		Mat thresh = new Mat();
		Cv2.AdaptiveThreshold(blurred, thresh, 255, AdaptiveThresholdTypes.GaussianC,
							  ThresholdTypes.BinaryInv, 11, 2);

		// Tìm contour
		Cv2.FindContours(thresh, out Point[][] contours, out HierarchyIndex[] hierarchy,
						 RetrievalModes.External, ContourApproximationModes.ApproxSimple);

		int index = 0;
		foreach (var contour in contours)
		{
			Rect rect = Cv2.BoundingRect(contour);
			if (rect.Width > 30 && rect.Height > 30)
			{
				Mat roi = new Mat(src, rect);
				string outPath = Path.Combine(outputFolder, $"crop_{index}.tif"); // 📌 TIFF
				Cv2.ImWrite(outPath, roi);
				index++;
			}
		}

		Console.WriteLine($"✅ Đã lưu {index} ảnh TIF vào thư mục '{outputFolder}'");
	}
}