using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URLEncoder
{
    class Program
    {
        static void Main(string[] args)
        {
            string projectName;
            string activityName;
                do
                {


                    Console.Write("Please enter the project name: ");
                    projectName = Console.ReadLine();
                    Console.WriteLine();
                    projectName = projectName.Replace(" ", "%20");

                    Console.Write("Please enter the activity name: ");
                    activityName = Console.ReadLine();
                    activityName = activityName.Replace(" ", "%20");

                    Console.WriteLine();
                    Console.Write("Your URL is: ");
                    Console.WriteLine("https://companyserver.com/content/" + projectName + "/files/" + activityName + "/" + activityName + "Report" + ".pdf");
                    Console.Write("Would you like to do another? (y/n): ");

                } while (Console.ReadLine().ToLower().Equals("y"));

         
            }
        }
    }

