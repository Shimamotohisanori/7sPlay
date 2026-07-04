using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/** ボタンの状態を管理するクラス */
public class BottomNavControllerScript : MonoBehaviour
{
    /** ここではボトムナビゲーションのボタンとスプライトを管理します */
    [SerializeField] private Image Home_Button;
    [SerializeField] private Image Daiitiran_Button;
    [SerializeField] private Image MyPage_Button;

    /** スプライトの参照を保持するための変数 */
    [SerializeField] private Sprite Light_Home;
    [SerializeField] private Sprite Dark_Home;

    /** スプライトの参照を保持するための変数 */
    [SerializeField] private Sprite Light_Daiitiran;
    [SerializeField] private Sprite Dark_Daiitiran;

    /** スプライトの参照を保持するための変数 */
    [SerializeField] private Sprite Light_MyPage;
    [SerializeField] private Sprite Dark_MyPage;

    /** ページマネージャーの参照を保持する変数 */
    public PageManagerScript pageManager;

    /** ホームボタンが押された時の関数 */
    public void OnHomePressed()
    {
        SetSelected(Home_Button, Light_Home);
        SetUnselected(Daiitiran_Button, Dark_Daiitiran);
        SetUnselected(MyPage_Button, Dark_MyPage);

        /** ページマネージャーのChangePage関数を呼び出して
         * ホームページに遷移する */
        pageManager.ChangePage(PageType.Home);
    }

    /** 台一覧ボタンが押されたときの関数 */
    public void OnDaiitiranPressed()
    {
        SetSelected(Daiitiran_Button, Light_Daiitiran);
        SetUnselected(Home_Button, Dark_Home);
        SetUnselected(MyPage_Button, Dark_MyPage);

        /** ページマネージャーのChangePage関数を呼び出して
         * 台一覧ページに遷移する */
        pageManager.ChangePage(PageType.Daiitiran);
    }

    /** マイページボタンが押されたときの関数 */
    public void OnMyPagePressed()
    {
        SetSelected(MyPage_Button, Light_MyPage);
        SetUnselected(Home_Button, Dark_Home);
        SetUnselected(Daiitiran_Button, Dark_Daiitiran);

        /** ページマネージャーのChangePage関数を呼び出して
         * マイページに遷移する */
        pageManager.ChangePage(PageType.MyPage);
    }

    /** 選択されたボタンのスプライトを変更する関数 */
    private void SetSelected(Image img, Sprite SelectedSprite)
    {
        img.sprite = SelectedSprite;
    }

    /** 選択されていないボタンのスプライトを変更する関数 */
    private void SetUnselected(Image img, Sprite UnselectedSprite)
    {
        img.sprite = UnselectedSprite;
    }



    // Start is called before the first frame update
    void Start()
    {
        /** ゲーム開始時はホームボタンを選択状態にする */
        SetSelected(Home_Button, Light_Home);
        SetUnselected(Daiitiran_Button, Dark_Daiitiran);
        SetUnselected(MyPage_Button, Dark_MyPage);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
