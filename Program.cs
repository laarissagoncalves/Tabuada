namespace Tabuada{
    class Program{
        public static void Main (string[] args){

            int tab, num;

            Console.Write("Entre com o valor que deseja fazer a tabuada: ");
            num = int.Parse(Console.ReadLine());
            for (int i=0; i<=10; i++){
                tab = num*i;
                if (i<10 && tab<10)
                    Console.WriteLine("{0} x  {1} =  {2}", num, i, tab);
                if (i<10 && tab>=10)
                    Console.WriteLine("{0} x  {1} = {2}", num, i, tab);
                if (i==10 && tab>=10)
                    Console.WriteLine("{0} x {1} = {2}", num, i, tab);
            }
        }
    }
}
