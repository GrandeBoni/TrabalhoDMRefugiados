using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogo : MonoBehaviour {

    private Text _textComponent;

    public string[] DialogueStrings;

    public float SecondsBetweenCharacters = 1f;
    public float CharacterRateMultiplier = 0.5f;

    public KeyCode DialogueInput = KeyCode.Mouse0;

    private bool _isDialoguePlaying = false;

    public GameObject proximoPainel;
    // Use this for initialization
    void Start()
    {
        _textComponent = GetComponent<Text>();
        _textComponent.text = "";           
    }

    // Update is called once per frame
    void Update()
    {  
            if (!_isDialoguePlaying)
            {
                _isDialoguePlaying = true;
                StartCoroutine(StartDialogue());
            }
    }

    private IEnumerator StartDialogue()
    {
        int dialogueLength = DialogueStrings.Length;
        int currentDialogueIndex = 0;

        while (currentDialogueIndex < dialogueLength)
        {
            yield return StartCoroutine(DisplayString(DialogueStrings[currentDialogueIndex]));
            currentDialogueIndex++;
        }
        AbreOProximoPainel();
        _isDialoguePlaying = false;
    }
    private IEnumerator DisplayString(string stringToDisplay)
    {
        int stringLength = stringToDisplay.Length;
        int currentCharacterIndex = 0;

        _textComponent.text = "";

        while (currentCharacterIndex < stringLength)
        {
            _textComponent.text += stringToDisplay[currentCharacterIndex];
            currentCharacterIndex++;
            if (currentCharacterIndex < stringLength)
            {
                if (Input.GetKey(DialogueInput))
                {
                    yield return new WaitForSeconds(SecondsBetweenCharacters * CharacterRateMultiplier);
                }
                else
                {
                    yield return new WaitForSeconds(SecondsBetweenCharacters);
                }
            }
            else
            {
                break;
            }
        }
        while (true)
        {
            if (Input.GetKeyDown(DialogueInput))
            {
                break;
            }
            yield return 0;
        }
        _textComponent.text = "";
    }
    void AbreOProximoPainel()
    {
        transform.parent.gameObject.SetActive(false);
        proximoPainel.SetActive(true);
    }
}