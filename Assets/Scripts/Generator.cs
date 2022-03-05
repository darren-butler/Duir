using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    [SerializeField] private GameObject block;
    [SerializeField] private int nodeCount = 100;

    private int x = 0;
    private int y = 0;

    // Start is called before the first frame update
    void Start()
    {
        Generate();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    // public static Object Instantiate(Object original, Vector3 position, Quaternion rotation, Transform parent);

    private void Generate()
    {
        for (int i = 0; i < nodeCount; i++)
        {
            bool xAxis = Random.Range(0, 100) % 2 == 0 ? true : false;
            bool positive = Random.Range(0, 100) % 2 == 0 ? true : false;

            if (xAxis)
            {
                if (positive)
                {
                    x++;
                }
                else
                {
                    x--;
                }
            }
            else
            {
                if (positive)
                {
                    y++;
                }
                else
                {
                    y--;
                }

            }

            Instantiate(block, new Vector3(x, y), Quaternion.identity);

        }
    }
}
