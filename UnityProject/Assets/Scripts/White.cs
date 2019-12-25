using UnityEngine;
using UnityEngine.SceneManagement;

public class White : MonoBehaviour
{
    #region 練習區域 - 在此區域內練習
    [Header("子彈")]
    public GameObject bullet;
    [Header("發射地點")]
    public Transform point;
    [Header("音效區域")]
    public AudioSource aud;
    public AudioClip clip;

    private void Update()
    {
        Shoot();
    }

    private void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            //生成子彈物件
            Instantiate(bullet, point.position, Quaternion.identity);
            aud.PlayOneShot(clip, 1);
        }
    }
    #endregion

    #region KID 區域 - 不要偷看 @3@
    [Header("移動速度"), Range(0f, 100f)]
    public float speed = 1.5f;

    private Rigidbody2D rig;

    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Move();
    }

    /// <summary>
    /// 移動
    /// </summary>
    private void Move()
    {
        rig.AddForce(transform.right * Input.GetAxisRaw("Horizontal") * speed);
    }
    #endregion
}
