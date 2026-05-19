using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieClicker
{
    public class Game
    {
        private double Cookies { get; set; }
        private double CookiesPerClick { get; set; }
        private double CookiesPerSecond { get; set; }
        private int TotalClicks { get; set; }

        /**
         * @returns amount of cookies given
         */
        public double handleClick()
        {
            this.Cookies += this.CookiesPerClick;
            return this.CookiesPerClick;
        }
    }
}
