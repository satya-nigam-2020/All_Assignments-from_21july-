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

        public void WorldCup()
        {
            Console.WriteLine("WorldCup-{0}",year);
        }
        public int Year
            {
               get;
               set;
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
        public void ShowCricketDetails()
        {
            Console.WriteLine("--------------------------Cricket Information--------------------------------------------");
            Console.WriteLine("Country : {0}");
            Console.WriteLine("Country  :  {0} No. Of Player : {1}  Coach Name : {2}",Country, noOfPlayer,coach);
           Console.WriteLine("Country  :  {0} No. Of Player : {1}  Coach Name : {2}",Country, noOfPlayer,coach);
            Console.WriteLine();
            Console.WriteLine();
        }

        public void ShowFootBallDetails()
        {
            Console.WriteLine("--------------------------FootBall Information--------------------------------------------");
           // Console.WriteLine("Country  :  {0} No. Of Player : {1}  League Name : {2}",Country, noOfPlayer, Leaguename);
           // Console.WriteLine("Country  :  {0} No. Of Player : {1}  League Name : {2}",Country, noOfPlayer, Leaguename);
            Console.WriteLine();
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            

            Cricket india=new Cricket(11,"India","Ravi Shastri");
            Cricket aus=new Cricket(11,"Australia","Micle clark");

            FootBall england= new FootBall(14,"England","FIFA");
             FootBall spain= new FootBall(13,"Spain","Spainish League");

            ShowGameDetails d=new ShowGameDetails();
            d.ShowCricketDetails();

            Game g=new Game();
            g.Year=2020;

            Console.ReadLine();
        }
    }
}
