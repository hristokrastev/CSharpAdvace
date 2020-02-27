﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Three
{
    public class Cage
    {
        private readonly List<Rabbit> data = new List<Rabbit>();

        public string Name { get; set; }

        public int Capacity { get; set; }

        public int Count => this.data.Count;


        private Cage()
        {
            this.data = new List<Rabbit>();
        }
        public Cage(string name, int capacity)
            :this()
        {
            this.Name = name;
            this.Capacity = capacity;
        }

        public void Add(Rabbit rabbit)
        {

            if (this.data.Count + 1 <= this.Capacity)
            {
                this.data.Add(rabbit);
            }
            
        }

        public bool RemoveRabbit(string name)
        {
            Rabbit rabbit = this.data.FirstOrDefault(r => r.Name == name);

            if (rabbit != null)
            {
                this.data.Remove(rabbit);
                return true;
            }

            return false;
        }

        public void RemoveSpecies(string species)
        {
            this.data.RemoveAll(r => r.Species == species);
        }
        public Rabbit SellRabbit(string name)
        {
            Rabbit rabbit = this.data.FirstOrDefault(r => r.Name == name);

            if (rabbit != null)
            {
                rabbit.Available = false;
            }

            return rabbit;
        }

        public Rabbit[] SellRabbitsBySpecies(string species)
        {
            Rabbit[] rabbits = this.data.Where(r => r.Species == species).ToArray();

            foreach (var rabbit in rabbits)
            {
                rabbit.Available = false;
            }
            return rabbits;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Rabbits available at {this.Name}:");

            foreach (var rabbit in this.data.Where(r => r.Available))
            {
                sb.AppendLine(rabbit.ToString());
            }

            return sb.ToString().TrimEnd();
        }

    }
}