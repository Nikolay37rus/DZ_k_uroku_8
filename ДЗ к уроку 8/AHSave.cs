using UnityEngine;

public class AHSave : MonoBehaviour
{

    public GameObject namePan;

    private void Start()
    {
        if (!PlayerPrefs.HasKey("Name")) namePan.SetActive(true);
        else Debug.Log("Добро пожаловать: " + PlayerPrefs.GetString("Name") + "\nВаш возраст: " + PlayerPrefs.GetInt("Age"));
    }

    public void CheckName(string name)
    {
        if (!string.IsNullOrEmpty(name) && name.Length >= 3)
        {
            PlayerPrefs.SetString("Name", name);
            Debug.Log("Ваше имя: " + name);
        }
        else Debug.Log("Введите нормальное имя!");
    }
    public void CheckAge(string age)
    {
        if (!string.IsNullOrEmpty(age) && age.Length > 0)
        {
            PlayerPrefs.SetInt("Age", int.Parse(age));
            Debug.Log("Ваш возраст: " + age);
        }
        else Debug.Log("Введите нормальный возраст!");
    }

}
