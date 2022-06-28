using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Cs_GO
{
    class DesertEagle:Silahlar
    {
        
        public override void Vur()
        {
            SoundPlayer Vurmasesi = new SoundPlayer("deagleses.wav");
            Vurmasesi.Play();
        }
        public override int kalanmermi { get; set; } = 7;


    }
}
