using System;
using System.Collections.Generic;

namespace RNATranscriptionModule
{
    public static class RnaTranscription
    {
        public static string ToRna(string nucleotide)
        {
            char[] input = nucleotide.ToCharArray();
            Dictionary<char, char> rna_dna = new Dictionary<char, char>();
            rna_dna.Add('G', 'C');
            rna_dna.Add('C', 'G');
            rna_dna.Add('T', 'A');
            rna_dna.Add('A', 'U');
            //Console.Write(rna_dna['A']);
            char[] rnaString = new char[nucleotide.Length];
            for (int i = 0; i < nucleotide.Length; i++)
            {
                rnaString[i] = rna_dna[input[i]];
            }
            string output = new string(rnaString);
            return output;
        }

    }

    //throw new NotImplementedException("You need to implement this function.");
}

