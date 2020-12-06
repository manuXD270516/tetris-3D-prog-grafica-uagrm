using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using tetris3Dv1.tipos;

namespace tetris3Dv1.App_Utils
{
    public class UtilsApp
    {
        public const string SONIDO_JUEGO_TETRIS = "juego tetris";
        public const string SONIDO_GAMEOVER_TETRIS = "game over tetris";
        public const string SONIDO_FILA_COMPLETA ="file completa tetris";
        //public const string SONIDO_JUEGO_TETRIS = "juego tetris";
        public const int PUNTUACION = 200;

        public static Array tiposCamaras = Enum.GetValues(typeof(Tipo_Camara));

    }
}
