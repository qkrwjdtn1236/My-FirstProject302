using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player
{
    private string name;
    private int level = 1;

    public Player(string name)
    {
        this.name = name;
    }
    
    public void PlayerInfo()
    {
        Debug.Log("이름 : " + this.name);
        Debug.Log("레벨 : " + this.level);
    }

    public void LevelUp()
    {
        this.level++;
        Debug.Log("레벨 업");
    }
    public void SetName(string name)
    {
        this.name = name;
        Debug.Log("이름을 변경했습니다 (변경 : " + this.name + ")");
    }
    public void SetLevel(int level)
    {
        this.level = level;
        Debug.Log("레벨 변경했습니다 (변경 : "+this.level+")");
    }
}

public class NewBehaviourScript1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Player myPlayer = new Player("박정수");
        myPlayer.PlayerInfo();
        myPlayer.LevelUp();
        myPlayer.PlayerInfo();
    }


}
