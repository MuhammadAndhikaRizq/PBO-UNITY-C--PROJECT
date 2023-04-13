using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human 
{
    //Atribut
    #region Fields
    private string firstName = "";
    private string lastName = "";
    private int umur = 0;
    private bool hasRightHand = true;
    private bool hasLeftRightHand = true;
    #endregion

    //Properties dari atribut, encapsulate
    #region Properties
    public string FirstName
    {
        //mengambil nilai dari atribut firstname
        get{
            return firstName;
        }
    }

    public string FullName 
    {
        get
        {
            return firstName + " " + lastName;
        }
    }

    #endregion Properties

    //Constructor
    #region Constructor
    public Human()
    {}

    public Human(string firstName, string lastName, int umur){
        //thi refer ke atribut class
        this.firstName = firstName;
        this.lastName = lastName;
        this.umur = umur;
    }
    #endregion

    #region MethodOverride
    public override string ToString()
    {
        return firstName + " " + lastName + " " + umur;
    }
    #endregion

    #region Methods
    public bool IsValid()
    {
        if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
        {
            return false;
        }
        return true;
    }

    public bool IsDewasa()
    {
        return umur >= 18;
    }

    public int SizeFullName()
    {
        return firstName.Length + lastName.Length;
    }

    #endregion
}
