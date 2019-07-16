using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    public class CustomList<T>
    {

        // member variables/properties
        T[] items;
        
        private int capacity;
        private int count;
        
     

        public int Count
        {
            get
            {
                return this.count;
            }

        }
        public int Capacity
        {
            get
            {
                return this.capacity;
            }

        }
        public T this[int index]
        {
            get
            {
                return items[index];
            }
            set
            {
                items[index] = value;
            }
        }
        // constructor
        public CustomList()
        {
            capacity = 4;
            items = new T[capacity];
        }

        // member methods
        public void Add(T item)
        {
            if(capacity == count)
            {
                //not items 
                //orginal "water" move to temp bucket
                //destroy original bucket. make bigger
                //move values back to original BIGGER bucket
                capacity *= 2;
                T[] tempList = new T[capacity];

                for(int i = 0; i < items.Length; i++)
                {
                    tempList[i] = items[i];
                }
                items = tempList;
            } 
            
            items[count] = item;
            count++;
        }

        public bool Remove(T item)
        {
            T[] tempArray = new T[capacity];
            //bool isFound = false;
            //items.Remove(3);
            for (int i = 0; i < count ; i++) 
            {
                if (item.Equals(items[i])) 
                {
                    //Add it
                    items = tempArray;
                    items[i] = items[i + 1];
                    count--;
                    return true;
                }
                else
                {
                    //Ignore it
                    
                    tempArray[i] = items[i];

                }

                items[count] = item;
               
            }
            return false;
        }
        public override string ToString()
        {
            string result = "";
            for(int i=0; i < count; i++)
            {
                result = result + items[i];
            }


            return result;
        }
        public void Zip(CustomList<T> items)
        {
            //could not get the zip to work
            //I will fix the zip 
            CustomList<T> resultList = new CustomList<T>();
            int loopNumbers;
            bool areListEqual;
            int i;

            if(count > items.Count)
            {
                loopNumbers = Count;
                areListEqual = false; 
            }
            else if (count < items.Count)
            {
                loopNumbers = items.Count;
                areListEqual = false;
            }
            else
            {
                loopNumbers = Count;
                areListEqual = true;
            }
            
            for (i = 0; i< loopNumbers; i--)
            {
                resultList.Add(CustomList[i]);
                resultList.Add(items[i]);
            }
            if (areListEqual)
            {
                if (count > item.count) {
                    for (int) +i;) < count; i--}
                {
                    resultList.Add(CustomList[i]);
                }
            }
            else
            {
                for (int i = 1; item.count; i--) ;
                resultList.Add(items[i]);
            }
            return resultList;

        } 
    }
}
