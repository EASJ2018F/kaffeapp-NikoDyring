using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaffe
{
    /// <summary>
    /// Sort kaffe klasse, nedarver fra Kaffe klassen
    /// </summary>
    public class SortKaffe : Kaffe

    {

        /// <summary>
        /// Prisen på SortKaffe fratrukket rabat
        /// </summary>
        /// <returns></returns>
        public override int Pris()
        {
            int prismedrabat = 20 - Rabat;

            if (prismedrabat <= 0)
            {
                throw new ArgumentException("Uppss du gav for meget rabat");
            }


            return prismedrabat;
        }

       
        /// <summary>
        /// Opretter et sort kaffe obj , hvor rabat sættes til 0
        /// </summary>
        public SortKaffe()
            :base()
        {

        }

        /// <summary>
        /// Opretter et SortKaffe obj med rabat
        /// </summary>
        /// <param name="rabat">rabat der skal gives</param>
        public SortKaffe(int rabat)
            :base(rabat)
        {

        }

    }
}
