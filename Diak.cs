using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Karesz
{
    public partial class Form1 : Form
    {
        void DIÁK_ROBOTJAI()
        {
            Robot karesz = Robot.Get("Karesz");

            karesz.Feladat = delegate ()
            {

            };
        }
    }
}

/* LEGFONTOSABB PARANCSOK

MOZGÁSOK

Lépj()                          -------- Karesz előre lép egyet.
Fordulj(jobbra)                 -------- Karesz jobbra fordul.
Fordulj(balra)                  -------- Karesz balra fordul.
Vegyél_fel_egy_kavicsot()       -------- Karesz felvesz egy kavicsot.
Tegyél_le_egy_kavicsot()        -------- Karesz letesz egy fekete kavicsot
Tegyél_le_egy_kavicsot(piros)   -------- Karesz letesz egy piros kavicsot.

SZENZOROK

Van_e_előttem_fal()                     -------- igaz, ha Karesz fal előtt áll, egyébként hamis.
Kilépek_e_a_pályáról()                  -------- igaz, ha Karesz a pálya szélén kifele néz, egyébként hamis.
Mi_van_alattam()                        -------- a kavics színe, amin Karesz áll. (Ez igazából egy szám!)
Van_e_itt_Kavics()                      -------- igaz, ha Karesz épp kavicson áll, egyébként hamis.
Köveinek_száma_ebből()                  -------- Karesz piros köveinek a száma.

*/
