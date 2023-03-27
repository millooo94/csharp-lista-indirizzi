﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lista_indirizzi
{
    public static class Saver
    {
        public const string InputFile = "..\\..\\..\\addresses.csv";
        public const string OutputFile = "..\\..\\..\\output.txt";

        public static IEnumerable<Address> Read()
        {
            using var input = File.OpenText(InputFile);

            var addresses = new List<Address>();
            input.ReadLine();
            while (true)
            {
                string? line = input.ReadLine();

                if (line is null) return addresses;

                var chunks = line.Split(',');

                string name = "";
                string secondName = "";
                string surname = "";
                string street = "";
                string city;
                string zip;
                string province;
                if (chunks.Length == 6)
                {
                    name = chunks[0];
                    surname = chunks[1];
                    street = chunks[2];
                    city = chunks[3];
                    province = chunks[4];
                    zip = chunks[5];
                }
                else if (chunks.Length == 4)
                {
                    name = chunks[0];
                    city = chunks[1];
                    province = chunks[2];
                    zip = chunks[3];
                }
                else if (chunks.Length == 7)
                {
                    name = chunks[0];
                    secondName = chunks[1];
                    surname = chunks[2];
                    street = chunks[3];
                    city = chunks[4];
                    province = chunks[5];
                    zip = chunks[6]; 
                }
                else
                {
                    surname = chunks[0];
                    city = chunks[1];
                    province = chunks[2];
                    zip = chunks[3];
                }

                var address = new Address(name, secondName, surname, street, city, province, zip);
                addresses.Add(address);
            }
        }
    public static void Write(IEnumerable<Address> addresses)
        {
            using var output = File.CreateText(OutputFile);

            foreach (var address in addresses)
            {
                output.WriteLine();
                output.WriteLine($"Nome: {address.Name}{Environment.NewLine}Secondo nome: {address.SecondName}{Environment.NewLine}Cognome: {address.Surname}{Environment.NewLine}Via: {address.Street}{Environment.NewLine}Città: {address.City}{Environment.NewLine}Provincia: {address.Province}{Environment.NewLine}CAP: {address.Zip} {address.Province} {address.Zip}");
                output.WriteLine();
            }
        }
    }
}
