using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    class MyList<T>
    {
        const int DEFAULT_SIZE = 1;
        T[] _data = new T[DEFAULT_SIZE];

        public int Count=0; // 사용중인 데이터 개수
        public int Capacity { get { return _data.Length; } } // 예약된 데이터 개수 -> 

        public void Add(T item)
        {
            // 1.공간이 충분히 남아 있는지 확인한다.
            if(Count >= Capacity)
            {
                // 공간 다시 늘려서 확보한다.
                T[] newArray = new T[Count *2]; 
                for (int i = 0; i < Count; i++)
                    newArray[i] = _data[i];
                _data = newArray;
            }
            // 2.공간에 데이터를 넣어준다.

            _data[Count] = item;
            Count++;
        }

        public T this[int index]  //인덱서 문법 
        {
            get { return _data[index]; }
            set { _data[index] = value; }
        }

        public void RemoveAt(int index)
        {
            for(int i= index;i< Count - 1; i++) 
            {
                _data[i] = _data[i + 1]; //최대 대입될 수 있는 수는 _data[i-1]이 된다.
            }
            _data[Count - 1] = default(T); // type에 맞춰 밀어버림
            Count--;
        }
    }

    class Board
    {
        public int[] _data = new int[25]; // array
        public MyList<int> _data2 = new MyList<int>(); // 동적 배열
        public LinkedList<int> _data3 = new LinkedList<int>(); // 연결 리스트 

        public void Initialize()
        {
            _data2.Add(101);
            _data2.Add(102);
            _data2.Add(103);
            _data2.Add(104);
            _data2.Add(105);

            int temp = _data2[2]; //third

            _data2.RemoveAt(2);
        }
    }
}
