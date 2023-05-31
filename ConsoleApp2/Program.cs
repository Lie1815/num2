// See https://aka.ms/new-console-template for more information

using System;
     
class Program {
    public static int Main() {
        Console.Write("Введите диапазон от 2 до  ");
        int end=int.Parse(Console.ReadLine());
        for(int i=2; i<=end; i++) {
            bool b=true;
            for(int j=2; j<i; j++) {
                if(i%j==0 & i%1==0) {
                    b=false;
                }
            }
            if(b) {
                Console.Write("{0} ", i);
            }
        }
        Console.ReadKey();
        return 0;
    }
}