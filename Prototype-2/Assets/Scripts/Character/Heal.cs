using UnityEngine.UI;
using UnityEngine;

public class Heal : MonoBehaviour
{
    PlayerStatManager playerStatManager;
    [SerializeField] private Slider hpProgressUI = null;

    void Awake()
    {
        playerStatManager = FindObjectOfType<PlayerStatManager>();
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (playerStatManager.currentHp < playerStatManager.maxPlayerHP)
        {
            playerStatManager.currentHp = playerStatManager.maxPlayerHP;
            GameManager.Instance.Progress.currentHp = playerStatManager.currentHp;
            hpProgressUI.value = playerStatManager.currentHp;
            GameManager.Save();
        }
    }
}
