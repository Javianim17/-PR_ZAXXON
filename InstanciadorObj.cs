using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciadorObj : MonoBehaviour
{
    [SerializeField] Transform initPos;

    [SerializeField] GameObject[] arrayObst;
    int level;
    float intervalo;
    InitGameScript initGameScript;

    // Start is called before the first frame update
    void Start()
    {
        initGameScript = GameObject.Find("InitGame").GetComponent<InitGameScript>();
        intervalo = 1f;

        StartCoroutine("CrearObstaculos");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator CrearObstaculos()
    {
        
        while (true)
        {
            
            Vector3 instPos = new Vector3(Random.Range(-10f, 10f), 0f, initPos.position.z);

            
            int randomNum;
            
            level = initGameScript.levelGame;
            
            if (level == 0)
            {
                randomNum = 0;
            }
            else if (level > 0 && level < 4)
            {
                randomNum = Random.Range(0, 5);
            }
            else
            {
                
                randomNum = Random.Range(0, arrayObst.Length);
            }

            
            Instantiate(arrayObst[randomNum], instPos, Quaternion.identity);

            yield return new WaitForSeconds(intervalo);

        }
    }
}
