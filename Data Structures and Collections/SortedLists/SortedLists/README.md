# Sorted List

> The SortedList class represents a collection of key-and-value pairs that are sorted by the keys and are accessible by key and by index.

> A sorted list is a combination of an array and a hash table. It contains a list of items that can be accessed using a key or an index. If you access items using an index, it is an ArrayList, and if you access items using a key, it is a Hashtable. The collection of items is always sorted by the key value.
---
## Methods and Properties of the SortedList Class
>The following table lists some of the commonly used properties of the SortedList class −

### **Property & Description**
---
1. #### _**Capacity**_
> This property gets or sets the capacity of a SortedList object.
---
2. #### _**Count**_
> This property gets the number of elements contained in a SortedList object.
---
3. #### _**IsFixedSize**_
> This property gets a value indicating whether a SortedList object has a fixed size.
---
4. #### _**IsReadOnly**_
> This property gets a value indicating whether a SortedList object is read-only.
---
5. #### _**IsSynchronized**_
> This property gets a value indicating whether access to a SortedList object is synchronized.
---
6. #### _**Item[Object]**_
> This property gets and sets the value associated with a specific key in a SortedList object.
---
7. #### _**Keys**_
> This property gets the keys in a SortedList object.
---
8. #### _**SyncRoot**_
> This property gets an object that can be used to synchronize access to a SortedList object.
---
9. #### _**Values**_
> This property gets the values in a SortedList object.
---
## Methods in SortedList Collection
>The different methods and their description is given as follows:

### **Method & Description**
---
1. #### _**public virtual void Add(object key, object value);**_
> Adds an element with the specified key and value into the SortedList.
---
2. #### _**public virtual void Clear();**_
> Removes all elements from the SortedList.
---
3. #### _**public virtual bool ContainsKey(object key);**_
> Determines whether the SortedList contains a specific key.
---
4. #### _**public virtual bool ContainsValue(object value);**_
> Determines whether the SortedList contains a specific value.
---
5. #### _**public virtual object GetByIndex(int index);**_
> Gets the value at the specified index of the SortedList.
---
6. #### _**public virtual object GetKey(int index);**_
> Gets the key at the specified index of the SortedList.
---
7. #### _**public virtual IList GetKeyList();**_
> Gets the keys in the SortedList.
---
8. #### _**public virtual IList GetValueList();**_
> Gets the values in the SortedList.
---
9. #### _**public virtual int IndexOfKey(object key);**_
> Returns the zero-based index of the specified key in the SortedList.
---
10. #### _**public virtual void Remove(object key);**_
> Removes the element with the specified key from the SortedList.
---
11. #### _**public virtual void RemoveAt(int index);**_
> Removes the element at the specified index of SortedList.
---
12. #### _**public virtual void TrimToSize();**_
> Sets the capacity to the actual number of elements in the SortedList.
---
### **Adding elements in SortedList**
>Elements can be added to the SortedList using the Add() method. It adds the specified key and value pairs to the dictionary. The program that demonstrates this is given as follows:

>Source Code: Program to add elements in SortedList in C#

``` C#
using System;
using System.Collections.Generic;
namespace SortedListDemo
{
  class Example
  {
     static void Main(string[] args)
     {
       SortedList<int, string> s = new SortedList<int, string>();
       s.Add(9,"Harry");
       s.Add(2,"Sally");
       s.Add(3,"Clarke");
       s.Add(1,"James");
       s.Add(7,"Emma");
       s.Add(6,"Susan");
       Console.WriteLine("SortedList elements are as follows:");
       foreach (KeyValuePair<int, string> i in s)
       {
           Console.WriteLine("Key: {0}     Value: {1}", i.Key, i.Value);
       }
     }
  }
}

```
#### **The output of the above program is as follows:**

``` C#
SortedList elements are as follows:
Key: 1     Value: James
Key: 2     Value: Sally
Key: 3     Value: Clarke
Key: 6     Value: Susan
Key: 7     Value: Emma
Key: 9     Value: Harry
```
### **Deleting elements from SortedList**
>An element can be deleted from the SortedList using the Remove() method. This method deletes the key, value pair with the specific key that is provided. The program that demonstrates this is given as follows:

>Source Code: Program to delete elements from SortedList in C#

``` C#
using System;
using System.Collections.Generic;
namespace SortedListDemo
{
  class Example
  {
     static void Main(string[] args)
     {
       SortedList<int, string> s = new SortedList<int, string>();
       s.Add(9,"Harry");
       s.Add(2,"Sally");
       s.Add(3,"Clarke");
       s.Add(1,"James");
       s.Add(7,"Emma");
       s.Add(6,"Susan");  
       Console.WriteLine("Original SortedList elements:");
       foreach (KeyValuePair<int, string> i in s)
       {
           Console.WriteLine("Key: {0}     Value: {1}", i.Key, i.Value);
       }
       s.Remove(3);
       s.Remove(6);
       Console.WriteLine("SortedList elements after deletion:");
       foreach (KeyValuePair<int, string> i in s)
       {
           Console.WriteLine("Key: {0}     Value: {1}", i.Key, i.Value);
       }
     }
  }
}
```
#### **The output of the above program is as follows:**

```C#
Original SortedList elements:
Key: 1     Value: James
Key: 2     Value: Sally
Key: 3     Value: Clarke
Key: 6     Value: Susan
Key: 7     Value: Emma
Key: 9     Value: Harry

SortedList elements after deletion:
Key: 1     Value: James
Key: 2     Value: Sally
Key: 7     Value: Emma
Key: 9     Value: Harry
```


