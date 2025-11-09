using UnityEngine;
using TMPro;

public class UI_Notification : MonoBehaviour
{
    public static UI_Notification instance;

    [SerializeField] private GameObject panel;
    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private float showTime = 2f;

    private float timer = 0f;

    private void Awake()
    {
        instance = this;
        if (panel != null)
            panel.SetActive(false);
    }

    private void Update()
    {
        if (panel != null && panel.activeSelf)
        {
            timer -= Time.deltaTime;
            if (timer <= 0f)
            {
                panel.SetActive(false);
            }
        }
    }

    public void Show(string msg)
    {
        if (panel == null || text == null) return;

        text.text = msg;
        panel.SetActive(true);
        timer = showTime;
    }

    public static void ShowMessage(string msg)
    {
        if (instance != null)
        {
            instance.Show(msg);
        }
        else
        {
            Debug.Log(msg);
        }
    }
}