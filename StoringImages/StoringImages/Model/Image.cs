using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoringImages.Model
{
    internal class Image
    {
        public string FileName { get; set; }
        public byte[] imageData { get; set; }
        public long FileSize { get; set; }

        public Image(string fileName, byte[] imageData, long fileSize)
        {
            FileName = fileName;
            this.imageData = imageData;
            FileSize = fileSize;
        }
    }
}
