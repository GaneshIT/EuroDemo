using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileLibrary
{
    public class Samsung:Mobile
    {
        public void GetNetworkConnction()
        {
            Console.WriteLine("Network connected");
        }
        public void CameraClick()
        {
            Console.WriteLine("Clicked on camera");
        }
        public void CameraClick(string mode)
        {
            Console.WriteLine("Clicked on camer with "+mode);
        }

        public override void Dial()
        {
            Console.WriteLine("Samsung dial");
        }

    }
}
