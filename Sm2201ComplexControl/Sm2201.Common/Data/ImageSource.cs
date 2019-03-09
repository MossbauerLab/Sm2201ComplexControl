using System;
using System.Collections.Generic;
using System.Text;

namespace Sm2201.Common.Data
{
    public class ImageSource
    {
        public ImageSource()
        {
        }

        public ImageSource(string source, ImageSourceType sourceType)
        {
            Source = source;
            SourceType = sourceType;
        }

        /// <summary>
        ///    Источнимк изображений (тип задается в SourceType):
        ///    1. Путь к файлу
        ///    2. URL к камере 
        /// </summary>
        public string Source { get; set; }

        public ImageSourceType SourceType { get; set; }
    }
}
