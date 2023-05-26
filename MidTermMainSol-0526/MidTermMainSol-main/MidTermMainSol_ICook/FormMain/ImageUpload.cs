using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormMain
{
	public class ImageUpload
	{
		public string UploadIMG()
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";// 設定檔案篩選器，只允許選擇圖片檔案（jpg、jpeg、png 格式）
			string picture = string.Empty;  // 初始化圖片路徑為空字串
			if (openFileDialog.ShowDialog() == DialogResult.OK) // 如果使用者選擇了檔案並按下「確定」按鈕
			{
				picture = openFileDialog.FileName;  // 取得選擇的圖片路徑
			}
			Bitmap images = new Bitmap(picture);

			Random rand = new Random(Guid.NewGuid().GetHashCode());
			string fileExt = rand.ToString()+ Path.GetExtension(picture);
			string name = rand.Next(10001, 99999).ToString();
			string savePath = @"image/" + name + fileExt;
			images.Save(savePath);
			return savePath;
		}
	}
	
}
