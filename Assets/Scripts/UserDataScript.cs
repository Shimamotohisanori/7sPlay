using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/** ユーザーの情報を管理するクラス */
[CreateAssetMenu(fileName = "UserData", menuName = "Game/UserData")]
public class UserDataScript : ScriptableObject
{
    /** ユーザーの名前 */
    public string userName;

    /** ユーザーのVコイン */
    public int vcoin;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
