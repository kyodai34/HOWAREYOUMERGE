using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;
using UnityEngine.UI;

public class TypewriterEffectWithList : MonoBehaviour
{
    public GameObject MobText;
    private Text textComponent;
    public float charDelay = 0.01f;

    private bool isTyping = false;
    private List<string> textLines;
    private int currentLineIndex = 0;

    private int j = 0;

    public GameObject panel;
    private Button pnl;
    public GameObject butController;

    private ButtonControll btnControll;

    public Sprite[] srites;
    public SpriteRenderer mobik;

    public AudioSource ambient;
    public AudioSource TheSlowTrack;
    public AudioSource GoodEnd;
    public AudioSource BadEnd;
    public AudioSource Tolpa;
    private int musI;

    private void Start()
    {
        btnControll = butController.GetComponent<ButtonControll>();
        textComponent = MobText.GetComponent<Text>();
        textLines = TextContainer.textMob[j];
        textComponent.text = "";
        pnl = panel.GetComponent<Button>();
        StartTyping();
    }

    public void StartTyping()
    {
        if (!isTyping)
        {
            StartCoroutine(TypeText());
        }
        else
        {
            StopCoroutine(TypeText());
            textComponent.text = "";
            textComponent.text = TextContainer.textMob[TextContainer.currentText][TextContainer.currentLine];
            TextContainer.currentLine += 1;
            isTyping = false;
            if (TextContainer.currentText == 2 && TextContainer.currentLine == 1)
            {
                ambient.Pause();
                TheSlowTrack.Play();
            }
            if (TextContainer.currentText == 2 && TextContainer.currentLine == TextContainer.textMob[TextContainer.currentText].Count)
            {
                ambient.Play();
                TheSlowTrack.Pause();
            }
            if (TextContainer.currentText == 5 && TextContainer.currentLine == 0)
            {
                ambient.Pause();
                TheSlowTrack.Play();
            }
            if (TextContainer.currentText == 5 && TextContainer.currentLine == 4)
            {
                ambient.Play();
                TheSlowTrack.Pause();
            }
            
            
            
            
            if (TextContainer.currentLine == TextContainer.textMob[TextContainer.currentText].Count)
            {
                if (TextContainer.currentText == 0)
                {
                    btnControll.FirstEvent();
                    TextContainer.currentLine = 0;
                    pnl.interactable = false;
                }
                else if (TextContainer.currentText == 1)
                {
                    TextContainer.currentText = 3;
                    TextContainer.currentLine = 0;
                    pnl.interactable = true;
                }
                else if (TextContainer.currentText == 2)
                {
                    TextContainer.currentText = 3;
                    TextContainer.currentLine = 0;
                    pnl.interactable = true;
                }
                else if (TextContainer.currentText == 3)
                {
                    btnControll.SecondEvent();
                    TextContainer.currentLine = 0;
                    pnl.interactable = false;
                }
                else if (TextContainer.currentText == 4)
                {
                    TextContainer.currentText = 6;
                    TextContainer.currentLine = 0;
                    pnl.interactable = true;
                }
                else if (TextContainer.currentText == 5)
                {
                    TextContainer.currentText = 6;
                    TextContainer.currentLine = 0;
                    pnl.interactable = true;
                }
                else if (TextContainer.currentText == 6)
                {
                    btnControll.ThirdEvent();
                    TextContainer.currentLine = 0;
                    pnl.interactable = false;
                }
                else if (TextContainer.currentText == 7)
                {
                    TextContainer.currentText = 10;
                    TextContainer.currentLine = 0;
                    pnl.interactable = true;
                }
                else if (TextContainer.currentText == 9)
                {
                    TextContainer.currentText = 10;
                    TextContainer.currentLine = 0;
                    pnl.interactable = true;
                }
                else if (TextContainer.currentText == 10)
                {
                    btnControll.FourthEvent();
                    TextContainer.currentLine = 0;
                    pnl.interactable = false;
                }
                else if (TextContainer.currentText == 11)
                {
                    TextContainer.currentText = 11;
                    TextContainer.currentLine = 0;
                    pnl.interactable = true;
                }
                else if (TextContainer.currentText == 12)
                {
                    TextContainer.currentText = 12;
                    TextContainer.currentLine = 0;
                    pnl.interactable = true;
                }
            }
        }
    }

    private IEnumerator TypeText()
    {
        isTyping = true;
        textComponent.text = "";

        foreach (char c in TextContainer.textMob[TextContainer.currentText][TextContainer.currentLine])
        {
            textComponent.text += c;
            yield return new WaitForSeconds(charDelay);
        }

        TextContainer.currentLine += 1;
        isTyping = false;
        
        if (TextContainer.currentText == 2 && TextContainer.currentLine == 1)
        {
            ambient.enabled = false;
            Debug.Log("mussss");
            TheSlowTrack.Play();
        }
        if (TextContainer.currentText == 2 && TextContainer.currentLine == TextContainer.textMob[TextContainer.currentText].Count)
        {
            ambient.Play();
            TheSlowTrack.Pause();
        }
        if (TextContainer.currentText == 5 && TextContainer.currentLine == 0)
        {
            ambient.Pause();
            TheSlowTrack.Play();
        }
        if (TextContainer.currentText == 5 && TextContainer.currentLine == 4)
        {
            ambient.Play();
            TheSlowTrack.Pause();
        }
        
        
        
        
        if (TextContainer.currentLine == TextContainer.textMob[TextContainer.currentText].Count)
            {
                if (TextContainer.currentText == 0)
                {
                    btnControll.FirstEvent();
                    TextContainer.currentLine = 0;
                    pnl.interactable = false;
                }
                else if (TextContainer.currentText == 1)
                {
                    TextContainer.currentText = 3;
                    TextContainer.currentLine = 0;
                    pnl.interactable = true;
                }
                else if (TextContainer.currentText == 2)
                {
                    TextContainer.currentText = 3;
                    TextContainer.currentLine = 0;
                    pnl.interactable = true;
                }
                else if (TextContainer.currentText == 3)
                {
                    btnControll.SecondEvent();
                    TextContainer.currentLine = 0;
                    pnl.interactable = false;
                }
                else if (TextContainer.currentText == 4)
                {
                    TextContainer.currentText = 6;
                    TextContainer.currentLine = 0;
                    pnl.interactable = true;
                }
                else if (TextContainer.currentText == 5)
                {
                    TextContainer.currentText = 6;
                    TextContainer.currentLine = 0;
                    pnl.interactable = true;
                }
                else if (TextContainer.currentText == 6)
                {
                    btnControll.ThirdEvent();
                    TextContainer.currentLine = 0;
                    pnl.interactable = false;
                }
                else if (TextContainer.currentText == 7)
                {
                    TextContainer.currentText = 10;
                    TextContainer.currentLine = 0;
                    pnl.interactable = true;
                }
                else if (TextContainer.currentText == 9)
                {
                    TextContainer.currentText = 10;
                    TextContainer.currentLine = 0;
                    pnl.interactable = true;
                }
                else if (TextContainer.currentText == 10)
                {
                    btnControll.FourthEvent();
                    TextContainer.currentLine = 0;
                    pnl.interactable = false;
                }
                else if (TextContainer.currentText == 11)
                {
                    TextContainer.currentText = 11;
                    TextContainer.currentLine = 0;
                    pnl.interactable = true;
                }
                else if (TextContainer.currentText == 12)
                {
                    TextContainer.currentText = 12;
                    TextContainer.currentLine = 0;
                    pnl.interactable = true;
                }
            }
    }
}