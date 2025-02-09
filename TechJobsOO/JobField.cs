﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TechJobsOO
{
    public abstract class JobField
    {
        public int Id { get; set; }
        private static int nextId = 1;
        public string Value { get; set; }
        public JobField()
        {
            Id = nextId;
            nextId++;
        }
        public JobField(string value) : this()
        {
            Value = value;
        }
        public override string ToString()
        {
            return Value;
        }
    }
}
