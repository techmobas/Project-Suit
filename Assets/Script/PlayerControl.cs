using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControl : MonoBehaviour
{
    public RPSControl rpsControl;

    private RPSInput rpsInput;
  
    private void Awake()
    {
        rpsInput = new RPSInput();
    }

    private void OnEnable()
    {
        rpsInput.Enable();

        rpsInput.Player.Rock.started += Rock;
        rpsInput.Player.Rock.performed += Rock;
        rpsInput.Player.Rock.canceled += Rock;

        rpsInput.Player.Paper.started += Paper;
        rpsInput.Player.Paper.performed += Paper;
        rpsInput.Player.Paper.canceled += Paper;

        rpsInput.Player.Scissors.started += Scissors;
        rpsInput.Player.Scissors.performed += Scissors;
        rpsInput.Player.Scissors.canceled += Scissors;
    }

    private void OnDisable()
    {
        rpsInput.Disable();

        rpsInput.Player.Rock.started -= Rock;
        rpsInput.Player.Paper.started -= Paper;
        rpsInput.Player.Scissors.started -= Scissors;
    }

    private void Start()
    {
        ;
    }

    private void Rock(InputAction.CallbackContext context)
    {
        Debug.Log("I choose Rock");
        context.ReadValue<float>();
        context.ReadValueAsButton();
    }

    private void Paper(InputAction.CallbackContext context)
    {
        Debug.Log("I choose Peper");
        context.ReadValue<float>();
        context.ReadValueAsButton();
    }

    private void Scissors(InputAction.CallbackContext context)
    {
        Debug.Log("I choose Scissors");
        context.ReadValue<float>();
        context.ReadValueAsButton();
    }

    void Update()
    {
        
    }
}
