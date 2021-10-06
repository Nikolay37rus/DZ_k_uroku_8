using UnityEngine;

public class AHSave : MonoBehaviour
{

    public GameObject namePan;

    private void Start()
    {
        if (!PlayerPrefs.HasKey("Name")) namePan.SetActive(true);
        else Debug.Log("����� ����������: " + PlayerPrefs.GetString("Name") + "\n��� �������: " + PlayerPrefs.GetInt("Age"));
    }

    public void CheckName(string name)
    {
        if (!string.IsNullOrEmpty(name) && name.Length >= 3)
        {
            PlayerPrefs.SetString("Name", name);
            Debug.Log("���� ���: " + name);
        }
        else Debug.Log("������� ���������� ���!");
    }
    public void CheckAge(string age)
    {
        if (!string.IsNullOrEmpty(age) && age.Length > 0)
        {
            PlayerPrefs.SetInt("Age", int.Parse(age));
            Debug.Log("��� �������: " + age);
        }
        else Debug.Log("������� ���������� �������!");
    }

}
