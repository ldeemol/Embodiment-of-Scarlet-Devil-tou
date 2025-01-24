using UnityEngine;

public class PlayerFireBullet : MonoBehaviour
{
    //총알 스피드를 관리해준것들
    float BulletFireCoolTime;
    float shootSpeed;
    float Lazer;
    float SubBulletFireCoolTime;
    float SubshootSpeed;

    //총알의 업글을 담당해주것들
    int BulletPower;

    public GameObject NormalBullet;
    public GameObject SubBullet;
    public GameObject Bomb;

    //총알이 나갈곳을 만들어줄것들
    Vector2 FireBulletposition;
    Quaternion FireBulletrotation;
    Vector2 SubFireBulletposition;
    Quaternion Bombrotation;

    //총알의 파워를 정해줌
    public int power { get;  private set; }
    
    

    void Start()
    {
        shootSpeed = 0;
        BulletFireCoolTime = 0.05f;//17
        SubBulletFireCoolTime = 0.2f;//30
        power = 100;//마음대로
    }

    void power8()
    {
        if (shootSpeed > BulletFireCoolTime)
        {
            Instantiate(NormalBullet, transform.position, transform.rotation);
            shootSpeed = 0;
        }
    }

    void power16()
    {
        if (shootSpeed > BulletFireCoolTime)
        {

            Instantiate(NormalBullet, transform.position, transform.rotation);

            shootSpeed = 0;
        }

        if (SubshootSpeed > SubBulletFireCoolTime)
        {
            SubFireBulletposition.y += 0.2f;
            SubFireBulletposition.x += 0.5f;
            Instantiate(SubBullet, SubFireBulletposition, transform.rotation);
            SubFireBulletposition.x -= 1.0f;
            Instantiate(SubBullet, SubFireBulletposition, transform.rotation);
            SubshootSpeed = 0;
        }
    }

    void power32()
    {
        if (shootSpeed > BulletFireCoolTime)
        {
            FireBulletposition.x += 0.2f;
            Instantiate(NormalBullet, FireBulletposition, transform.rotation);
            FireBulletposition.x -= 0.4f;
            Instantiate(NormalBullet, FireBulletposition, transform.rotation);
            shootSpeed = 0;
        }

        if (SubshootSpeed > SubBulletFireCoolTime)
        {
            SubFireBulletposition.y += 0.2f;
            SubFireBulletposition.x += 0.5f;
            Instantiate(SubBullet, SubFireBulletposition, transform.rotation);
            SubFireBulletposition.x -= 1.0f;
            Instantiate(SubBullet, SubFireBulletposition, transform.rotation);
            SubshootSpeed = 0;
        }
    }

    void power64()
    {
        if (shootSpeed > BulletFireCoolTime)
        {
            Instantiate(NormalBullet, transform.position, transform.rotation);
            FireBulletrotation.z -= 0.05f;
            Instantiate(NormalBullet, transform.position, FireBulletrotation);
            FireBulletrotation.z += 0.1f;
            Instantiate(NormalBullet, transform.position, FireBulletrotation);
            shootSpeed = 0;
        }
        if (SubshootSpeed > SubBulletFireCoolTime)
        {
            SubFireBulletposition.y += 0.2f;
            SubFireBulletposition.x += 0.5f;
            Instantiate(SubBullet, SubFireBulletposition, transform.rotation);
            SubFireBulletposition.x -= 1.0f;
            Instantiate(SubBullet, SubFireBulletposition, transform.rotation);
            SubshootSpeed = 0;
        }
    }

    void power80()
    {
        if (shootSpeed > BulletFireCoolTime)
        {
            Instantiate(NormalBullet, transform.position, transform.rotation);
            FireBulletrotation.z -= 0.05f;
            Instantiate(NormalBullet, transform.position, FireBulletrotation);
            FireBulletrotation.z += 0.1f;
            Instantiate(NormalBullet, transform.position, FireBulletrotation);
            shootSpeed = 0;
        }
        if (SubshootSpeed > SubBulletFireCoolTime)
        {
            SubFireBulletposition.y += 0.2f;
            SubFireBulletposition.x += 0.5f;
            Instantiate(SubBullet, SubFireBulletposition, transform.rotation);
            SubFireBulletposition.x -= 1f;
            Instantiate(SubBullet, SubFireBulletposition, transform.rotation);
            SubshootSpeed = 0;
        }
    }

    void Maxpower()
    {
        if (shootSpeed > BulletFireCoolTime)
        {
            Instantiate(NormalBullet, transform.position, transform.rotation);
            FireBulletrotation.z -= 0.05f;
            Instantiate(NormalBullet, transform.position, FireBulletrotation);
            FireBulletrotation.z += 0.1f;
            Instantiate(NormalBullet, transform.position, FireBulletrotation);
            shootSpeed = 0;
        }
        if (SubshootSpeed > SubBulletFireCoolTime)
        {
            SubFireBulletposition.y += 0.2f;

            SubFireBulletposition.x += 0.5f;
            Instantiate(SubBullet, SubFireBulletposition, transform.rotation);
            SubFireBulletposition.x -= 0.25f;
            Instantiate(SubBullet, SubFireBulletposition, transform.rotation);
            SubFireBulletposition.x -= 0.5f;
            Instantiate(SubBullet, SubFireBulletposition, transform.rotation);
            SubFireBulletposition.x -= 0.25f;
            Instantiate(SubBullet, SubFireBulletposition, transform.rotation);
            SubshootSpeed = 0;
        }
    }

    void UseBomb()
    {
        Instantiate(Bomb, transform.position, Bombrotation);

        Instantiate(Bomb, transform.position, Bombrotation);

        Instantiate(Bomb, transform.position, Bombrotation);

    }

    void Update()
    {
        FireBulletposition = transform.position;
        SubFireBulletposition = transform.position;
        FireBulletrotation = transform.rotation;
        Bombrotation = transform.rotation;
        if (Input.GetKey(KeyCode.Z))
        {
            shootSpeed += Time.deltaTime;
            SubshootSpeed += Time.deltaTime;

            if (power >= 100)
            {
                Maxpower();
            }
            if (power >= 64 && power <= 80)
            {
                power80();
            }
            if (power >= 32 && power <= 64)
            {
                power64();
            }
            if (power >= 16 && power <= 32)
            {
                power32();
            }
            if (power >= 8 && power <= 16)
            {
                power16();
            }
            if (power < 8)
            {
                power8();
            }

        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            UseBomb();
        }
    }
}
