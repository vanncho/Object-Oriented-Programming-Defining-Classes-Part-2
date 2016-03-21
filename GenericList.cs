namespace Homework
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    public class GenericList<T> where T : IComparable<T>
    {
        private T[] element;
        private int index;

        public GenericList(int capacity)
        {
            this.element = new T [capacity];
            this.index = 0;
        }

        public T this[int index]
        {
            get { return this.element[index]; }
            set
            {
                if (index < 0 || index > this.element.Length)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.element[index] = value;
            }
        }

        public void AddElement(T element)
        {
            this.element[index] = element;
            index++;

            if (this.index == this.element.Length)
            {
                T[] resized = new T[this.element.Length * 2];
                this.element = CopyValuesInNewArray(this.element, resized);
            }
        }

        public void Clear()
        {
            this.element = new T[5];
            this.index = 4;
        }

        public void InsertAtIndex(int index, T element)
        {
            T[] newArray = new T[this.element.Length + 1];
            int insertIndex = 0;

            for (int i = 0; i < newArray.Length; i++)
            {
                if (i == index)
                {
                    newArray[i] = element;
                    this.index++;
                    insertIndex--;
                }
                else
                {
                    newArray[i] = this.element[insertIndex];
                }

                insertIndex++;
            }

            this.element = newArray;
        }

        /// <summary>
        /// Return the index of searched element
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public int FindElement(T element)
        {
            for (int i = 0; i < this.index; i++)
            {
                if (this.element[i].Equals(element))
                {
                    return i;
                }
            }

            return -1;
        }

        public T Min()
        {
            T min = this.element[0];

            for (int i = 1; i < this.index; i++)
            {
                if (this.element[i].CompareTo(min) < 0)
                {
                    min = this.element[i];
                }
            }

            return min;
        }

        public T Max()
        {
            T max = this.element[0];

            for (int i = 1; i < this.index; i++)
            {
                if (this.element[i].CompareTo(max) > 0)
                {
                    max = this.element[i];
                }
            }

            return max;
        }

        public void RemoveElement(int index)
        {
            CheckIndex(index);

            T[] newElement = new T[this.element.Length - 1];
            int removedIndex = 0;
            bool removedElement = false;

            for (int i = 0; i < newElement.Length; i++)
            {
                if (i.Equals(index))
                {
                    removedIndex++;
                    newElement[i] = this.element[removedIndex];
                    removedElement = true;
                }
                else
                {
                    newElement[i] = this.element[removedIndex];
                }

                removedIndex++;
            }

            if (removedElement)
            {
                this.element = newElement;
                this.index--;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public override string ToString()
        {
            var output = new T[index];

            for (int i = 0; i < index; i++)
            {
                output[i] = this.element[i];
            }
            if (index == 0)
            {
                return "List is empty";
            }

            return string.Join(", ", output);
        }

        private void CheckIndex(int index)
        {
            if (index < 0 || index > this.index - 1)
            {
                throw new IndexOutOfRangeException();
            }
        }

        private T[] CopyValuesInNewArray(T[] oldArray, T[] newResized)
        {
            for (int i = 0; i < oldArray.Length; i++)
            {
                newResized[i] = oldArray[i];
            }

            return newResized;
        }
    }
}
