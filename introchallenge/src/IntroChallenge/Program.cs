﻿using System;
using System.Collections.Generic;
using System.IO;
class Solution {

    static int solveMeFirst(int a, int b) { 
      if(a <= 0 || b >= 1000){
        Console.WriteLine("Variables provided are out of bounds");
        return 0;
      }
      else{
          return a+b;
      }
      
    }

    static void Main(String[] args) {
        int val1 = Convert.ToInt32(Console.ReadLine());
        int val2 = Convert.ToInt32(Console.ReadLine());
        int sum = solveMeFirst(val1,val2);
        Console.WriteLine(sum);
    }
}      