﻿namespace FizzBuzz.Models
{
    public class FizzBuzzModel
    {
        public int FizzValue { get; set; }
        public int BuzzValue { get; set; }
        public List<string>? Result { get; set; } = new();
    }
}
