using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using tetris3Dv1.tipos;

namespace tetris3Dv1
{
    public class Sonido
    {
        public string nombre { get; set; }
        public string ruta { get; set; }
        public Estado_Sonido estado { get; set; }


        public Sonido():this(string.Empty,string.Empty){}

        public Sonido(string nombre,string ruta,Estado_Sonido estado=Estado_Sonido.STOP)
        {
            this.nombre = nombre;
            this.ruta = ruta;
            this.estado = estado;
        }

        public void play(bool repetead=false)
        {
            if (!estado.Equals(Estado_Sonido.PLAY))
            {
                using (SoundPlayer s = new SoundPlayer(ruta))
                {
                    if (repetead)
                    {
                        s.PlayLooping();
                    } else
                    {
                        s.Play();
                    }

                    
                }                
            }
        }

        public void stop()
        {
            if (estado.Equals(Estado_Sonido.PLAY))
            {
                using (SoundPlayer s = new SoundPlayer(ruta))
                {
                    s.Stop();
                }
            }
        }

    }
}
