using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Lists
    {
        public static List<string> mainList = new List<string>()
        { "Adjektiv","Adverb","Konjunktioner","Personliga pronomen","Verb" };

        public static List<string> adjectiveList = new List<string>()
        { "röd","sur","svart","tjock","stor","underbar","vacker","snygg","stor","kraftig","fin","lång","glad","rund","trött" };

        public static List<string> adverbList = new List<string>()
        { "flitigt", "hårt", "bra", "högt", "ofta", "snabbt", "rakt","högljutt", "mjukt", "farligt", "sakta" };

        public static List<string> conjunctionList = new List<string>()
        { "och","eller","utan","men","för","ty","samt","fast","både – och","varken – eller","antingen – eller","dels – dels","såväl – som" };

        public static List<string> personalPronounList = new List<string>()
        { "Han","Hon","Den","Det","De" };

        public static List<string> verbList = new List<string>()
        { "springer","pratar","jobbar","hoppar","bakar","trycker","dansar","spikar","vinglar","äter" };
    }
}
