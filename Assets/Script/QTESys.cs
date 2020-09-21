using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QTESys : MonoBehaviour
{

    public enum QTState { Ready, Delay, Ongoing, Done };
    public QTState qtState = QTState.Ready;
    // an enum for a possible response!
    public enum QTResponse { Null, Success, Fail };
    public QTResponse qtResponse = QTResponse.Null;

    // Should we pick a random button?
    public bool isRandom = true;
    // We use keycodes here, but you could do a list of string for buttons or replace with a better input manager.
    // Atleast select one keycode for this list for it to work!
    public List<KeyCode> Buttons = new List<KeyCode>();
    // We use this as a selection pointer for our random/not random variable.
    private int ran = 0;

    // How long should the event last?
    public float CountTimer = 2f;
    // Should we wait before the event starts?
    public float DelayTimer = 0f;

    // The Player tag for which we trigger the event on!
    public string PlayerTag = "Player";

    public Text ButtonDisplay;

    private void Awake()
    {
        if (Buttons.Count <= 0)
        {
            print("You haven't added any buttons yet!");
        }
    }

    private void Update()
    {
        if (qtState == QTState.Ongoing)
        {
            if (isRandom)
            {
                if (Input.GetKeyDown(Buttons[ran]))
                {
                    qtState = QTState.Done;
                    qtResponse = QTResponse.Success;
                    // We ready the gui text for the next event/time.
                    ButtonDisplay.text = string.Empty;
                    StopCoroutine(StateChange());
                }
            }
            else
            {
                if (Input.GetKeyDown(Buttons[ran]))
                {
                    qtState = QTState.Done;
                    qtResponse = QTResponse.Success;
                    // We ready the gui text for the next event/time.
                    ButtonDisplay.text = string.Empty;
                    StopCoroutine(StateChange());
                }
            }
        }
    }

    private IEnumerator StateChange()
    {
        qtState = QTState.Delay;
        // Wait for the Delay if any delay at all.
        yield return new WaitForSeconds(DelayTimer);
        // If we want a random button we use Random.Range, otherwise we set it to the first button in the list!
        if (isRandom)
        {
            ran = Random.Range(0, Buttons.Count);
        }
        else
        {
            ran = 0;
        }
        // This line below is only for Debug Purposes
        print(Buttons[ran]);
        // This adds the selected button to the display GUI and makes it uppercase instead of lowercase.
        ButtonDisplay.text = Buttons[ran].ToString().ToUpper();
        qtState = QTState.Ongoing;
        yield return new WaitForSeconds(CountTimer);
        // If the timer is over and the event isn't over? Fix it! because most likely they failed.
        if (qtState == QTState.Ongoing)
        {
            qtResponse = QTResponse.Fail;
            qtState = QTState.Done;
            // We ready the gui text for the next event/time.
            ButtonDisplay.text = string.Empty;
        }
    }

    // For 3D Collision
    void OnTriggerEnter(Collider other)
    {
        if (qtState == QTState.Ready && other.tag == PlayerTag)
        {
            StartCoroutine(StateChange());
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (qtState == QTState.Done && other.tag == PlayerTag)
        {
            qtState = QTState.Ready;
            qtResponse = QTResponse.Null;
        }
    }

    // For 2D Colission
    void OnTriggerEnter2D(Collider2D other)
    {
        if (qtState == QTState.Ready && other.tag == PlayerTag)
        {
            StartCoroutine(StateChange());
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (qtState == QTState.Done && other.tag == PlayerTag)
        {
            qtState = QTState.Ready;
            qtResponse = QTResponse.Null;
        }
    }


}
