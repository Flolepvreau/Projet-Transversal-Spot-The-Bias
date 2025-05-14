using UnityEngine;

public class ClickableObject : MonoBehaviour
{
    public string objectName;

    void OnMouseDown()
    {
        Debug.Log("Tu as cliqué sur : " + objectName);
        Interact();
    }

    void Interact()
    {
        // Exemples d’interactions
        switch (objectName)
        {
            case "truc":
                UIManager.Instance.ShowMessage("le truc est activé");
                break;
            case "chose":
                UIManager.Instance.ShowMessage("la chose est activé");
                break;
            case "machin":
                UIManager.Instance.ShowMessage("le machiin est activé");
                break;
        }
    }
}
