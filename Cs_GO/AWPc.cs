using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Cs_GO
{
    class AWPc:Silahlar
    {
        public override void Vur()
        {
            SoundPlayer Vurmasesi = new SoundPlayer("awpses.wav");
            Vurmasesi.Play();
        }
    }
}
