using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveScript : MonoBehaviour
{

    public static int PlayerHealth = 100;
    public static bool HealthChanged = false;
    public static float BatteryPower = 1.0f;
    public static bool BatteryRefill = false;
    public static bool FlashLightOn = false;
    public static bool NVLightOn = false;
    public static int Apples = 0;
    public static int Batteries = 0;
    public static bool Knife = false;
    public static bool Bat = false;
    public static bool Axe = false;
    public static bool Gun = false;
    public static bool Crossbow = false;
    public static bool CabinKey = false;
    public static bool HouseKey = false;
    public static bool RoomKey = false;
    public static int BulletClips = 0;
    public static bool ArrowRefill = false;
    public static bool HaveKnife = false;
    public static bool HaveBat = false;
    public static bool HaveAxe = false;
    public static bool HaveGun = false;
    public static bool HaveCrossbow = false;
    public static int Bullets = 12;
    public static bool BulletDecount = false;
    public static int Arrows = 6;
    public static bool NewGame = false;
    public static Transform Target1;
    public static Transform Target2;
    public static Transform Target3;
    public static Transform Target4;
    public static Transform Target5;
    public static Transform Target6;
    public static Transform Target7;
    public static Transform Target8;
    public static Transform Target9;
    public static Transform Target10;
    public static Transform PlayerChar;
    public static GameObject Chase;
    public static GameObject HurtScreen;
    public static AudioSource StabSound;
    public static GameObject SplatKnife;
    public static GameObject SplatBat;
    public static GameObject SplatAxe;
    public static int MaxEnemiesOnScreen = 6;
    public static int EnemiesOnScreen = 0;
    public static int MaxEnemiesInGame = 100;
    public static int EnemiesCurrent = 0;


    [SerializeField] Transform _Target1;
    [SerializeField] Transform _Target2;
    [SerializeField] Transform _Target3;
    [SerializeField] Transform _Target4;
    [SerializeField] Transform _Target5;
    [SerializeField] Transform _Target6;
    [SerializeField] Transform _Target7;
    [SerializeField] Transform _Target8;
    [SerializeField] Transform _Target9;
    [SerializeField] Transform _Target10;
    [SerializeField] Transform PlayerPrefab;
    [SerializeField] GameObject ChaseMusic;
    [SerializeField] GameObject HurtUI;
    [SerializeField] AudioSource StabPlayer;
    [SerializeField] GameObject BloodSpatKnife;
    [SerializeField] GameObject BloodSpatBat;
    [SerializeField] GameObject BloodSpatAxe;

    private void Start()
    {
        Target1 = _Target1;
        Target2 = _Target2;
        Target3 = _Target3;
        Target4 = _Target4;
        Target5 = _Target5;
        Target6 = _Target6;
        Target7 = _Target7;
        Target8 = _Target8;
        Target9 = _Target9;
        Target10 = _Target10;
        PlayerChar = PlayerPrefab;
        Chase = ChaseMusic;
        HurtScreen = HurtUI;
        StabSound = StabPlayer;
        SplatKnife = BloodSpatKnife;
        SplatAxe = BloodSpatAxe;
        SplatBat = BloodSpatBat;

        if (NewGame == true) 
        {
    PlayerHealth = 100;
    HealthChanged = false;
    BatteryPower = 1.0f;
    BatteryRefill = false;
    FlashLightOn = false;
    NVLightOn = false;
    Apples = 0;
    Batteries = 0;
    Knife = false;
    Bat = false;
    Axe = false;
    Gun = false;
    Crossbow = false;
    CabinKey = false;
    HouseKey = false;
    RoomKey = false;
    BulletClips = 0;
    ArrowRefill = false;
    HaveKnife = false;
    HaveBat = false;
    HaveAxe = false;
    HaveGun = false;
    HaveCrossbow = false;
    Bullets = 12;
    BulletDecount = false;
    Arrows = 6;
        }
    }
}
