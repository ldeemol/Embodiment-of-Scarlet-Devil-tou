using UnityEngine;

public class NomalEnemy : MonoBehaviour
{
    Vector2 moveForce;

    float coolTime;
    float shootSpeed;
    int RandomItem;
    private int healthPoint; //체력 선언. private로 노출 방지


    public GameObject[] enemyBulletPrefab;
    public GameObject Power;
    public GameObject LifePoint;


    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "DestroyEnemy")
        {
            Destroy(gameObject);
        }
    }


    public int GetCurrentHP()
    {
        return healthPoint;
    }

    public void DecreaseHp() 
    {
        healthPoint -= 1;

        if (healthPoint <= 0) 
        {
            healthPoint = 0; 
            Die(); 
        }
    }

    void Die() 
    {
        Debug.Log(RandomItem);
        if (RandomItem == 1)
        {
            Instantiate(Power, transform.position, transform.rotation);
        }
        else
        {
            Instantiate(LifePoint, transform.position, transform.rotation);
        }
        GameObject.Find("GameManager").GetComponent<GameManager>().NomalAddScore();

        Destroy(gameObject);
    }
    void Start()
    {
        healthPoint = 1;//여기서 현제 체력넣음
        moveForce = transform.position;
        coolTime = 0;
        shootSpeed = 3.0f;
        RandomItem = Random.Range(1, 3);
    }



    void Update()
    {

        moveForce.y -= 0.01f;//이동만 시킬꺼임
        if (GameObject.Find("GameManager").GetComponent<GameManager>().Gameover == false)
        {
            coolTime += Time.deltaTime;
            if (coolTime >= shootSpeed)
            {

                Instantiate(enemyBulletPrefab[0], transform.position, transform.rotation);
                coolTime = 0;
            }
        }
       transform.position = moveForce;
    }
}
