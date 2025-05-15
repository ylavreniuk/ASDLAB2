using System;

public class DynamicArray
{
    private int[] array; 
    private int size; 
    private int capacity; 

    
    public DynamicArray(int initialCapacity = 10)
    {
        capacity = initialCapacity;
        array = new int[capacity];
        size = 0;
    }

    
    public void Add(int element, int index)
    {
        if (index < 0 || index > size)
            throw new ArgumentOutOfRangeException("Невалідний індекс");

        
        if (size == capacity)
        {
            capacity *= 2;
            Array.Resize(ref array, capacity);
        }

        
        for (int i = size; i > index; i--)
            array[i] = array[i - 1];

        array[index] = element;
        size++;
    }

    
    public void AddToEnd(int element)
    {
        Add(element, size);
    }

    
    public void Remove(int index)
    {
        if (index < 0 || index >= size)
            throw new ArgumentOutOfRangeException("Невалідний індекс");

        
        for (int i = index; i < size - 1; i++)
            array[i] = array[i + 1];

        size--;
    }

    
    public int GetByIndex(int index)
    {
        if (index < 0 || index >= size)
            throw new ArgumentOutOfRangeException("Невалідний індекс");
        return array[index];
    }

    
    public int FindByValue(int value)
    {
        for (int i = 0; i < size; i++)
            if (array[i] == value)
                return i;
        return -1; 
    }

    
    public string GetArrayAsString()
    {
        string result = "";
        for (int i = 0; i < size; i++)
            result += array[i] + " ";
        return result.Trim();
    }

    
    public long CalculateEvenIndexedProduct()
    {
        long product = 1;
        for (int i = 0; i < size; i += 2)
            product *= array[i];
        return product;
    }

   
    public int CalculateSumBetweenZeros()
    {
        int firstZero = -1, lastZero = -1;

        
        for (int i = 0; i < size; i++)
        {
            if (array[i] == 0)
            {
                firstZero = i;
                break;
            }
        }

        
        for (int i = size - 1; i >= 0; i--)
        {
            if (array[i] == 0)
            {
                lastZero = i;
                break;
            }
        }

       
        if (firstZero == -1 || lastZero == -1 || firstZero == lastZero)
            return 0;

        
        int sum = 0;
        for (int i = firstZero + 1; i < lastZero; i++)
            sum += array[i];

        return sum;
    }

    
    public void SortPositiveNegative()
    {
        int[] temp = new int[size];
        int posIndex = 0, negIndex = size - 1;

        
        for (int i = 0; i < size; i++)
        {
            if (array[i] >= 0)
                temp[posIndex++] = array[i];
        }

        
        for (int i = 0; i < size; i++)
        {
            if (array[i] < 0)
                temp[negIndex--] = array[i];
        }

        
        Array.Copy(temp, array, size);
    }
}
