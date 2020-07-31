using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAMEINHERITENCE
{
   public class Game
    {
      public int noOfPlayer;
        public string Country;
        int year;

        public Game()
        {

        }

        public Game( int _noOfPlayer, string _country)
        {
            noOfPlayer = _noOfPlayer;
            Country = _country;
        }

        public void WorldCup(string country, string game)
        {
            Console.WriteLine("{0} have won the {1} WorldCup : {2}",country,game,year);
        }
        public int Year
            {
            get { return year; }
            set { year = value; }
            }
    }

   public class Cricket : Game
        {
        
          public string coach;
           
         
       public Cricket ()
	   {

	   }
        public Cricket (int _noOfPlayer, string _country, string _coach):base(_noOfPlayer, _country)
	   {
        
            coach=_coach;

	   }

        }

   public class FootBall : Game
        {

       public string  Leaguename;
        public FootBall ()
	{

	}

        public FootBall (int _noOfPlayer, string _country, string _Leaguename):base(_noOfPlayer, _country)
	    {
            Leaguename=_Leaguename;

	    }

    }

    class ShowGameDetails
    {
        public void ShowCricketDetails(string country, int noOfPlayers, string Coach)
        {
           
            Console.WriteLine("Country: {0} No of Players :{1} Coach :{2} ", country, noOfPlayers, Coach);
        }
        public void ShowFootBallDetails(string country, int noOfPlayers, string leageuname)
        {
           
            Console.WriteLine("Country: {0} No of Players :{1} Leaguename :{2} ", country, noOfPlayers, leageuname);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            

            Cricket india=new Cricket();
            Cricket aus=new Cricket();

            FootBall england= new FootBall();
            FootBall spain= new FootBall();

            ShowGameDetails d=new ShowGameDetails();
            Console.WriteLine("-----------------Cricket Information----------------------");
            d.ShowCricketDetails("India", 11, "Ravi Shastri");
            d.ShowCricketDetails("Australia", 11, "Micle Clark");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("-----------------FootBall Information----------------------");
            d.ShowFootBallDetails("England", 14, "English League");
            d.ShowFootBallDetails("Spain", 13, "Spainish League");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            Game g=new Game();
            g.Year=2011;
            g.WorldCup("India", "Cricket");
            g.WorldCup("Spain", "Football");
            Console.ReadLine();
        }
    }
}
