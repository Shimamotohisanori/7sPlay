using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

/** ページの管理を行うクラス */
/** プレイヤーがどのページを見ているのかを判別し
 * UI等を差し替える */


/** ページの種類 */
public enum PageType
{
    Home,
    Daiitiran,
    MyPage
}

public class PageManagerScript : MonoBehaviour
{
    /** ページの種類を管理する変数 */
    public GameObject homePage;
    public GameObject daiitiranPage;
    public GameObject myPage;

    /** ユーザーデータの参照を保持する変数 */
    public UserDataScript userData;

    /** ユーザー名 */
    public TextMeshProUGUI userNameText;

    /** ユーザーのVコイン */
    public TextMeshProUGUI vcoinText;

    /** ページを切り替える関数 */
    public void ChangePage(PageType page)
    {
        /** ページの切り替え */
        /** 例：ページのタイプがホームページなら
         * ホームページをアクティブにする */
        homePage.SetActive(page == PageType.Home);
        daiitiranPage.SetActive(page == PageType.Daiitiran);
        myPage.SetActive(page == PageType.MyPage);

        switch(page)
        {
            case PageType.Home:
                UpdateHomeUI();
                break;
            case PageType.Daiitiran:
                UpdateDaiitiranUI();
                break;
            case PageType.MyPage:
                UpdateMyPageUI();
                break;
        }
    }

    private void UpdateHomeUI()
    {
        // ホームページのUIを更新する処理をここに記述
        userNameText.text = userData.userName;
        vcoinText.text = userData.vcoin.ToString() + "VCoin";

        Debug.Log("ホームページに切り替えました");
    }

    private void UpdateDaiitiranUI()
    {
        // 台一覧ページのUIを更新する処理をここに記述
        Debug.Log("台一覧ページに切り替えました");
    }

    private void UpdateMyPageUI()
    {
        // マイページのUIを更新する処理をここに記述
        Debug.Log("マイページに切り替えました");
    }

    // Start is called before the first frame update
    void Start()
    {
        /** ランダムな数字を生成(1～9999) */
        int randomNumber = Random.Range(1, 10000);

        /** ユーザー名を設定 */
        userData.userName = "User" + randomNumber.ToString("D4");

        /** ゲーム開始時はホームページを表示する */
        ChangePage(PageType.Home);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
