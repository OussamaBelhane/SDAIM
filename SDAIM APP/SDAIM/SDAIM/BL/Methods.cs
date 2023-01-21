using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace SDAIM.BL
{
    class Methods
    {
        public MemoryStream ma = new MemoryStream();
        public byte[] by;

        // Convert to byte
        public byte[] convert_byte()
        {
            return ma.ToArray();
        }
        // Convert byt to image
        public MemoryStream convert_image()
        {
            ma = new MemoryStream(by);
            return ma;
        }
    }
}
