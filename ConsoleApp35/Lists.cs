using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Menu
    {
        public int Number { get; set; }
        public string Words { get; set; }
    }

    public class Lists
    {
        public static List<Menu> mainList = new List<Menu>()
        {
            new Menu() {Words="Adjektiv", Number=1},
            new Menu() {Words="Adverb", Number=2},
            new Menu() {Words="Konjunktioner", Number=3},
            new Menu() {Words="Personliga pronomen", Number=4},
            new Menu() {Words="Verb", Number=5},
        };

        public static List<Menu> adjectiveList = new List<Menu>()
        {
            new Menu() {Words="röd", Number=1},
            new Menu() {Words="sur", Number=2},
            new Menu() {Words="svart", Number=3},
            new Menu() {Words="tjock", Number=4},
            new Menu() {Words="stor", Number=5},
            new Menu() {Words="underbar", Number=6},
            new Menu() {Words="vacker", Number=7},
            new Menu() {Words="snygg", Number=8},
            new Menu() {Words="fin", Number=9},
            new Menu() {Words="kraftig", Number=10},
            new Menu() {Words="lång", Number=11},
            new Menu() {Words="glad", Number=12},
            new Menu() {Words="rund", Number=13},
            new Menu() {Words="trött", Number=14}
        };

        public static List<Menu> adverbList = new List<Menu>()
        {
            new Menu() {Words="sakta", Number=1},
            new Menu() {Words="flitigt", Number=2},
            new Menu() {Words="hårt", Number=3},
            new Menu() {Words="bra", Number=4},
            new Menu() {Words="högt", Number=5},
            new Menu() {Words="ofta", Number=6},
            new Menu() {Words="snabbt", Number=7},
            new Menu() {Words="rakt", Number=8},
            new Menu() {Words="högljutt", Number=9},
            new Menu() {Words="mjukt", Number=10},
            new Menu() {Words="farligt", Number=11}
        };

        public static List<Menu> conjunctionList = new List<Menu>()
        {
            new Menu() {Words="och", Number=1},
            new Menu() {Words="eller", Number=2},
            new Menu() {Words="utan", Number=3},
            new Menu() {Words="men", Number=4},
            new Menu() {Words="för", Number=5},
            new Menu() {Words="ty", Number=6},
            new Menu() {Words="samt", Number=7},
            new Menu() {Words="fast", Number=8},
        };

        public static List<Menu> personalPronounList = new List<Menu>()
        {
            new Menu() {Words="han", Number=1},
            new Menu() {Words="hon", Number=2},
            new Menu() {Words="den", Number=3},
            new Menu() {Words="det", Number=4},
            new Menu() {Words="De", Number=5}
        };

        public static List<Menu> verbList = new List<Menu>()
        {
            new Menu() {Words="springer", Number=1},
            new Menu() {Words="pratar", Number=2},
            new Menu() {Words="jobbar", Number=3},
            new Menu() {Words="hoppar", Number=4},
            new Menu() {Words="bakar", Number=5},
            new Menu() {Words="trycker", Number=6},
            new Menu() {Words="dansar", Number=7},
            new Menu() {Words="spikar", Number=8},
            new Menu() {Words="vinglar", Number=9},
            new Menu() {Words="äter", Number=10}
        };
    }
}
