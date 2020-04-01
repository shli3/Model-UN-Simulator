using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UNDelegate : MonoBehaviour
{
    
    public string country;
    public string attendance { get; private set;}  //A -> Absent, P -> Present (Can abstain), PV -> Present & Voting (Must vote)

    
    public UNDelegate(){
        country = "Neverland";
        attendance = "A";
    }

    public UNDelegate(string land){
        country = land;
        attendance = "A";
    }

    public UNDelegate(string land, string RollCall){
        country = land;
        attendance = RollCall;
    }


}
