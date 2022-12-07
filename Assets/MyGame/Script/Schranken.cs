using UnityEngine;

public class Schranken : MonoBehaviour
{
    [SerializeField]
    GameObject linksSchranke;
    [SerializeField]
    GameObject rechtsSchranke;
    public Animator anim;
    public Animator anim2;
    
    void Update()
    {
        if (!linksSchranke.activeSelf && !rechtsSchranke.activeSelf)
        {
            Debug.Log("ja");
            anim.SetTrigger("los");
            anim2.SetTrigger("los2");
        }
    }

    public void ButtonLinks()
    {
        if (linksSchranke.activeSelf)
        {
            linksSchranke.SetActive(false);

        }
        else
        {
            linksSchranke.SetActive(true);
        }
    }

    public void ButtonRechts()
    {
        if (rechtsSchranke.activeSelf)
        {
            rechtsSchranke.SetActive(false);

        }
        else
        {
            rechtsSchranke.SetActive(true);
        }
    }
}
