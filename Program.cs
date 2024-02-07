﻿using ClassLibrary.Lib;

namespace ClassLibrary
{
    internal partial class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter username: ");
            var userInput = Console.ReadLine();

            try
            {
            var username = GetNormalizedUsername(userInput);
            Console.WriteLine($"Username: {username}");

            }
            catch (InvalidUsernameException ex)
            {
                Console.WriteLine(ex.Message);
            }

            MessageProvider.Message();
        }

        private static string GetNormalizedUsername(string? username) 
        {
            if(string.IsNullOrEmpty(username) || username.Length< 6)
            {
                throw new InvalidUsernameException(username);
            }

            return username.ToLower();
        }
    }
}