
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5
{
    internal class Builder : IDeveloper
    {
        string tool;
        public string Tool
        {
            get { return tool; }
            set { tool = value; }
        }
        public Builder(string tool)
        {
            this.tool = tool;
        }

        public void Destroy()
        {
            Console.WriteLine($"Builder has destroyed something with his {tool}...");
        }
        public void Create()
        {
            Console.WriteLine($"Builder has used his {tool} to create something...");
        }
        int IComparable<IDeveloper>.CompareTo(IDeveloper other)
        {
            return String.Compare(this.Tool, other.Tool);
        }
        public override string ToString()
        {
            return String.Format($"This builder uses {tool}.");
        }
    }
}

