﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UserRoles.Contract.Models.Person
{
    public class PersonModel
    {
        public string Date { get; set; }

        public int Age { get; set; }

        private int _score;
        public int Score
        {
            set => _score = value;
            get => (int)((_score * 5) / 100);
        }
        public string Name { get; set; }
    }
}
