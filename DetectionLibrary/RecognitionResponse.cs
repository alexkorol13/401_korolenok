using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class RecognitionResponse
    {
        public Dictionary<string, int> Objects { get; set; }
        public int progress { get; set; }
        public List<List<float>> Rectangles { get; set; }
        public RecognitionResponse()
        {
            Objects = new Dictionary<string, int>();
            Rectangles = new List<List<float>>();
            progress = 0;
        }
    }
}