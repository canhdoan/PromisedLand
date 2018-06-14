using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stamina : MonoBehaviour {
    public float maxStamina;
    public float currentStamina;
    public float staminaRate;

    public float recoveryTime;
    public float timer;

    public bool refillStamina;

    // Use this for initialization
    void Start() {
        currentStamina = maxStamina;
    }

    // Update is called once per frame
    void Update() {
        if (timer != 0 && timer < recoveryTime)
        {
            timer += Time.deltaTime;

            if (timer > recoveryTime)
            {
                timer = 0;
                refillStamina = true;
            }
        }
        if (refillStamina)
        {
            currentStamina += staminaRate;
            if (currentStamina >= maxStamina)
            {
                currentStamina = maxStamina;
                refillStamina = false;
            }
        }
    }

    public void setCurrentStamina(float staminaValue)
    {
        currentStamina = staminaValue;
    }

    public void lowerStamina(float staminaValue)
    {
        currentStamina -= staminaValue;
        if(currentStamina < 0)
        {
            currentStamina = 0;
        }
        timer += (float)0.01;
        refillStamina = false;
    }

    public bool runningDrain(bool amIRunning, float drainRate)
    {
        if (amIRunning)
        {
            refillStamina = false;
            lowerStamina(drainRate);
            if (currentStamina > 0)
            {
                return true;
            }
            else
                return false;
        }
        else
            return false;
    }
}