using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Assignment_1
{
    public class Repost
    {
        public static Repost Instancia { get; } = new Repost();

        


        public FrmHome homeScreen {get;set;} = new FrmHome();

        public Repost()
        {

        }

    }
}
