{
    // My name is Mahmoud Mohamed Farrag Elkfrway   Sec 22
    Console.Title = "Mahmoud Elkfrawy";
    Console.ForegroundColor=ConsoleColor.Cyan;  // This is for font color
    DateTime now=DateTime.Now;       // This is for showing time
    Console.WriteLine("Today is " + now);
    Console.WriteLine("------------------------------\n");
           
    int minnum,maxnum,num,sum,i;
    Console.Write("Input the starting range : ");
    minnum = Convert.ToInt32(Console.ReadLine());  
    Console.Write("Input the ending range : ");
    maxnum = Convert.ToInt32(Console.ReadLine());
    Console.Write("The Perfect numbers are : ");

    for(num=minnum;num<=maxnum;num++)
    {
    i=1;
    sum = 0;
    while(i<num)
	  {
    if(num%i==0)
    sum=sum+i;
    i++;
    }
    if(sum==num)
    Console.Write(" " + num);
    }
    Console.ReadKey();
}     