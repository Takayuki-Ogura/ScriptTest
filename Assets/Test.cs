using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;       //体力
    private int power = 25;     //攻撃力
    private int mp = 53;        //int型の変数mpを宣言し、53で初期化

    //攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    //防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        //残りhpを減らす
        this.hp -= damage;
    }

    //Magic関数
    public void Magic(int mahou)
    {
        //this.mp -= mahou;　→→初回提出時
        //if (this.mp >= 5)　→→初回提出時
        if (this.mp >= mahou)
        {
            mp -= mahou;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。");
        }
        else
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
    }
}

public class Test : MonoBehaviour {

    void Start()
    {
        //Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        //攻撃用の関数を呼び出す
        lastboss.Attack();
        //防御用の関数を呼び出す
        lastboss.Defence(3);
        //Magic関数を呼び出す
        //lastboss.Magic(5);　→→3回目提出時に非表示


        //Magic関数を10回使った後に、更にMagic関数を呼び出すと、mpが足りないメッセージが表示される
        //for (int i = 0; i < 10; i++)　→→2回目提出時
        for (int i = 0; i < 11 ; i++)　//→→3回目提出時
        {
            lastboss.Magic(5);
        }



        //Bossクラスの変数を宣言してインスタンスを代入
        Boss midboss = new Boss();

        //攻撃用の関数を呼び出す
        midboss.Attack();
        //防御用の関数を呼び出す
        midboss.Defence(1);



        //【課題】配列を宣言して出力しましょう

        //要素の個数が5の、int型の配列arrayを宣言して初期化
        int[] array = { 4, 2, 1, 3, 0 };
        //for文を使って各要素を順番に表示する
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }
        
        //for文を使って各要素を逆番に表示する
        //for (int i = 4; 0 <= i; i--)　→→初回提出時
        for (int i = array.Length -1; 0 <= i; i--)
        {
            Debug.Log(array[i]);
        }



        //【発展課題】Bossクラスに、変数mpとMagic関数を作成してStart関数から呼び出しましょう
        //上記BOSSクラスに追記
    }


    // Update is called once per frame
    void Update () {
       
    }
}