using UnityEngine;

public class Singleton : MonoBehaviour
{
    private void Start()
    {
        AudioManager.Init();
        AudioManager.Instance.Play();
    }
}

public class AudioManager
{
    public AudioSource AudioSource;
    public static AudioManager Instance { get; private set; }

    public static void Init()
    {
        if (Instance == null)
        {
            Debug.Log("��� �������� ������ ������");
            Instance = new AudioManager();
            return;
        }
        else
        {
            Debug.Log("��� ���������� ������ ������, ������ �� �����");
        }
    }

    public void Play()
    {
        Debug.Log("�� �� ��");
    }
}


