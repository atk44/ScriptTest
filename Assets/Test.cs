using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;
    private int power = 25;
    public int mp = 53;

    public void Attack()
    {
        Debug.Log(this.power + "のダメージを受けた");
    }

    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        this.hp -= damage;
    }

    public void Magic()
    {
        int magicCost = 5;
        if(this.mp >= magicCost)
        {
            this.mp -= magicCost;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。");
        }
        else
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
    }
}

public class Test : MonoBehaviour {
	// Use this for initialization
	void Start () {
        int [] array = new int[5];
        for(int i = 0; i < array.Length; i++)
        {
            array[i] = i;
        }

        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }
        
        for (int i=0; i<5; i++)
        {
            int n = array.Length;
            Debug.Log(array[n - i - 1]);
        }


        Boss lastboss = new Boss();
        for(int i=0; i<11; i++)
        {
            lastboss.Magic();
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
