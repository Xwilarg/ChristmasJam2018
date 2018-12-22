using System.Collections.Generic;
using UnityEngine;

public static class Utils
{
    public static List<int> GetItems(int itemCount, int nbMin, int nbMax)
    {
        List<int> wishesId = new List<int>();
        int nbWishes = Random.Range(nbMin, nbMax);
        for (int i = 0; i < nbWishes;)
        {
            int id = Random.Range(0, itemCount - 1);
            if (!wishesId.Contains(id))
            {
                wishesId.Add(id);
                i++;
            }
        }
        return (wishesId);
    }
}
