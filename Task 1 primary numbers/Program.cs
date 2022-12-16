      {
            // My name is Mahmoud Mohamed Farrag Elkfrway   Sec 22
           Console.Title = "Mahmoud Elkfrawy";
           Console.ForegroundColor=ConsoleColor.Cyan;  // This is for font color
           DateTime now=DateTime.Now;       // This is showing time
           Console.WriteLine("Today is " + now);
           Console.WriteLine("------------------------------\n");
           
           System.Console.WriteLine("inter the start :");
           int num=int.Parse(Console.ReadLine());
           System.Console.WriteLine("inter the end :");
           int num1=int.Parse(Console.ReadLine());
           int num2=1;
           Console.Write("Primary numbers are :");
            if (num>=1)
            {
            for (int i = num; i <= num1; i++)
            {
            if (i==1)
            {
            continue;    
            }
            for (int x = 2; x <= num1; x++)
            {
            if (i != x && i % x == 0)
            {
            num2=0;
            break;
            }
            }
            if (num2==1)
            {
            Console.Write(" " + i);
            }
            num2 = 1;
            }
            }
            else
            {
            Console.WriteLine("invaled integer");
            }
           Console.ReadKey();  // This is for prevent program from closing
      }
      


        