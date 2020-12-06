using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tetris3Dv1.App_Model
{
    public class ConfiguracionUsuario
    {
        //private ConfiguracionUsuario configUser;

        public string nickName { get; set; }
        public string dificultad { get; set; }
        public TimeSpan tiempo { get; set; }
        public int puntos { get; set; }
        public bool reprodSonidos { get; set; }
        public int velocidadFiguras { get; set; }

        public ConfiguracionUsuario():this(string.Empty,string.Empty){}

        public ConfiguracionUsuario(string nickName,string dificultad="basico", TimeSpan tiempo=default(TimeSpan),int puntos=0, bool reprodSonidos=false,int velocidadFiguras = 0)
        {
            this.nickName = nickName;
            this.dificultad = dificultad;
            this.tiempo = tiempo;
            this.puntos = puntos;
            this.reprodSonidos = reprodSonidos;
            this.velocidadFiguras = velocidadFiguras;
        }

        public ConfiguracionUsuario(ConfiguracionUsuario configUser)
        {
            if (configUser != null)
            {
                nickName = configUser.nickName;
                dificultad = configUser. dificultad;
                tiempo = configUser.tiempo;
                puntos = configUser.puntos;
                reprodSonidos = configUser.reprodSonidos;
                velocidadFiguras = configUser.velocidadFiguras;
            }
            
        }
    }
}
