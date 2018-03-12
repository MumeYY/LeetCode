// 406. Queue Reconstruction by Height
// Suppose you have a random list of people standing in a queue. Each person is described by a pair of integers (h, k), where h is the height of the person and k is the number of people in front of this person who have a height greater than or equal to h. Write an algorithm to reconstruct the queue.

// Note:
// The number of people is less than 1,100.

// Example

// Input:
// [[7,0], [4,4], [7,1], [5,0], [6,1], [5,2]]

// Output:
// [[5,0], [7,0], [5,2], [6,1], [4,4], [7,1]]
// Subscribe to see which companies asked this question.
using System.Collections.Generic;
//总体来说先排序，第一总结就是排序大法好
partial class QueueReconstructionByHeight {
    public int[,] ReconstructQueue(int[,] people) {
        int PeopleNumber = people.GetLength(0);
        List<Data> peopleList = new List<Data>();
        for(int i = 0; i < PeopleNumber; ++i)
        {
            peopleList.Add(new Data(people[i, 0], people[i, 1]));
        }
        peopleList.Sort(new System.Comparison<Data>(Comparer));

        List<Data> resultList = new List<Data>();
        for(int i = 0; i < peopleList.Count; ++i)
        {
            Data tmp = peopleList[i];
            if(tmp.k >= resultList.Count)
            {
                resultList.Add(tmp);
            }
            else
            {
                resultList.Insert(tmp.k, tmp);
            }
        }
        int[,] result = new int[PeopleNumber, 2];
        for(int i = 0; i < resultList.Count; ++i)
        {
            result[i, 0] = resultList[i].h;
            result[i, 1] = resultList[i].k;
        }
        return result;
    }
    public int Comparer(Data a, Data b)
    {
        if(a.h != b.h)
        {
            return a.h > b.h ? -1 : 1;
        }
        else if(a.k != b.k)
        {
            return a.k < b.k ? -1 : 1;
        }
        return 0;
    }
    public class Data{
        public int h;
        public int k;

        public Data(int h, int k)
        {
            this.h = h;
            this.k = k;
        }
    }

}