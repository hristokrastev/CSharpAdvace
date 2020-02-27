using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListyIterator
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private List<T> data;

        private int currentIndex;

        public ListyIterator()
        {
            this.data = new List<T>();
            this.currentIndex = 0;
        }

        public void Create(List<T> items)
        {
            if (items.Count.Equals(0))
            {
                throw new ArgumentException("Invalid Operation!");
            }

            items.ForEach(x => data.Add(x));
        }

        public bool Move()
        {
            if (HasNext())
            {
                this.currentIndex++;
                return true;
            }

            return false;
        }

        public void Print()
        {
            if (this.data.Any())
            {
                Console.WriteLine(this.data[currentIndex]);
            }
        }

        public bool HasNext()
        {
            return this.currentIndex + 1 < this.data.Count;
        }

        public string PrintAll()
        {
            if (!this.data.Any())
            {
                throw new ArgumentException("Invalid Operation!");
            }

            var result = new StringBuilder();
            foreach (var item in this.data)
            {
                result.Append($"{item} ");
            }

            return result.ToString().Trim();
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.data.Count; i++)
            {
                yield return this.data[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}