using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class dialogManager : MonoBehaviour
{
    [SerializeField] private TMP_Text dialogText;
    [SerializeField] private TMP_Text nameText;

    [SerializeField] private Animator _animator;
    
    private Queue<string> sentences;
    
    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialog(dialog dialog)
    {
        _animator.SetBool("isOpen", true);
        
        nameText.text = dialog.name;
        
        sentences.Clear();

        foreach (string sentence in dialog.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();

    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialog();
            return;
        }

        string sentence = sentences.Dequeue();
        dialogText.text = sentence;
    }

    private void EndDialog()
    {
        _animator.SetBool("isOpen", false);
    }
}
