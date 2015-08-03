// Copyright © Microsoft Corporation. Alle Rechte vorbehalten.
// Dieser Code wird freigegeben gemäß den Bedingungen der 
// Microsoft Public License (MS-PL, http://opensource.org/licenses/ms-pl.html).
//
//Copyright (C) Microsoft Corporation. Alle Rechte vorbehalten.

// Hello3.cs
// Argumente: A B C D
using System;

public class Hello3
{
   public static void Main(string[] args)
   {
      Console.WriteLine("Hello, World!");
      Console.WriteLine("You entered the following {0} command line arguments:",
         args.Length );
      for (int i=0; i < args.Length; i++)
      {
         Console.WriteLine("{0}", args[i]); 
      }
   }
}

