using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieClicker
{
    public class Game
    {
        public double Cookies { get; private set; }
        public double CookiesPerClick { get; private set; }
        public double CookiesPerSecond { get; private set; }
        public int TotalClicks { get; private set; }

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
