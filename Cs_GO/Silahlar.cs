using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Cs_GO
{
    abstract class Silahlar : Oyuncu 
    {
     
        public virtual void Vur()
        {
            SoundPlayer Vurmasesi = new SoundPlayer(@"C:\Users\Enes\source\repos\Cs_GO\Cs_GO\Resources\sesler\csgo-desert-eagle-green-screen-overlay-sound-effect-high-quality-_AudioTrimmer.com_.wav");
            Vurmasesi.Play();
        }
       public virtual int kalanmermi { get; set; }
        

    }
}
