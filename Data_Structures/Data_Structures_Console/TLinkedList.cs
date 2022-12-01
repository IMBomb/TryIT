using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Standart emplimentation of Lists is List and LinkedList. There is a differance:
//     List<T> is backed by an array.This provides a very compact representation in memory.
//     Conversely, LinkedList<T> involves additional memory to store the bidirectional links between successive elements.


namespace Data_Structures_Console
{
    public class Node<T>
    {
        public Node(T data)
        {
            Data = data;
        }
        public T Data;// { get; set; }  //ZACHEM?????
        public Node<T> Next;// { get; set; } //ZACHEM?????
    }

    public class TLinkedList<T> //: IEnumerable<T>  // Dlya perebora foreach!!!!!
    {
        Node<T> head; // головной/первый элемент
        Node<T> tail; // последний/хвостовой элемент
        int count;  // количество элементов в списке

        // добавление элемента
        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);

            if (head == null)
                head = node;
            else
                tail.Next = node;
            tail = node;

            count++;
        }
        // удаление элемента
        public bool Remove(T data)
        {
            Node<T> current = head;
            Node<T> previous = null;

            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    // Если узел в середине или в конце
                    if (previous != null)
                    {
                        // убираем узел current, теперь previous ссылается не на current, а на current.Next
                        previous.Next = current.Next;

                        // Если current.Next не установлен, значит узел последний,
                        // изменяем переменную tail
                        if (current.Next == null)
                            tail = previous;
                    }
                    else
                    {
                        // если удаляется первый элемент
                        // переустанавливаем значение head
                        head = head.Next;

                        // если после удаления список пуст, сбрасываем tail
                        if (head == null)
                            tail = null;
                    }
                    count--;
                    return true;
                }

                previous = current;
                current = current.Next;
            }
            return false;
        }

        public int Count { get { return count; } }
    public bool IsEmpty { get { return count == 0; } }
    // очистка списка
    public void Clear()
    {
        head = null;
        tail = null;
        count = 0;
    }
    // содержит ли список элемент
    public bool Contains(T data)
    {
        Node<T> current = head;
        while (current != null)
        {
            if (current.Data.Equals(data))
                return true;
            current = current.Next;
        }
        return false;
    }
    // добвление в начало
    public void AppendFirst(T data)
    {
        Node<T> node = new Node<T>(data);
        node.Next = head;
        head = node;
        if (count == 0)
            tail = head;
        count++;
    }
    //// реализация интерфейса IEnumerable
    //IEnumerator IEnumerable.GetEnumerator()//
    //{                                               //Ne zabyvaem, chto dannyi class TLinkedList<T> naslednik ot interfeisa IEnumerable<T>
    //    return ((IEnumerable)this).GetEnumerator();//Vozvraschaet tekuschii nomerator vyzvavshego ego IEnumerable
    //}

    //IEnumerator<T> IEnumerable<T>.GetEnumerator()//Funkciya vozvraschaet nuerator
    //{
    //    Node<T> current = head; // Nachinaet s golovy
    //    while (current != null) //Pereberaet vseh, poka ne doidet do ne zapolnennogo
    //    {
    //        yield return current.Data;
    //        current = current.Next; //beret sleduuschi
    //    }
    //}
}


}
