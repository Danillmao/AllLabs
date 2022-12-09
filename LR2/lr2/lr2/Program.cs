using lr2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace LR2
{
    class Program
    {
        static void Main(string[] args)
        {
            ResearchTeam NewTeam = new ResearchTeam();
            NewTeam.OrgName = "Умару";
            NewTeam.Theme = "2д жизнь";
            NewTeam.RegNuber = 112994;
            NewTeam.ResearchTime = TimeFrame.TwoYears;
            Console.WriteLine(NewTeam.ToShortString());
            Console.WriteLine();

            
        }
    }
} //Person D = new ("Данил", "Морозов", new DateTime(2003, 09, 08));