using UnityEngine;
using UnityEngine.UI;

public class Black : MonoBehaviour
{
    #region 練習區域 - 在此區域內練習
    [Header("血量")]
    public int hp;
    [Header("血量介面")]
    public Text hpText;
    [Header("音效區域")]
    public AudioSource aud;
    public AudioClip clip;

    //碰撞時呼叫(因為子彈有on trigger所以用OnTriggerEnter)
    private void OnTriggerEnter2D(Collider2D hit)
    {
        if (hit.gameObject.CompareTag("子彈"))
        {
            Hit();
        }
    }

    private void Update()
    {
        if (hp <= 0)
        {
            Destroy(gameObject,0.1f);
        }
    }

    private void Hit()
    {
        hp -= 1;
        hpText.text = hp.ToString();
        aud.PlayOneShot(clip, 1);
    }
    #endregion
}
