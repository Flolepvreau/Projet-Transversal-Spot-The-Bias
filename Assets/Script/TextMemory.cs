using TMPro;
using UnityEngine;

public class TextMemory : MonoBehaviour
{
    public TMP_InputField TMP_InputField;
    private TMP_Text m_Text;

    private void Start()
    {
        m_Text = GetComponent<TMP_Text>();
    }

    public void AddText()
    {
        m_Text.text += TMP_InputField.text + "\n";
    }
}
