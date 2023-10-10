using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RunGame : MonoBehaviour
{
    //makes a board generator
    BoardGeneration _BoardGenerator  = new BoardGeneration();
    public List<Player> _player;




    // Start is called before the first frame update
    void Start()
    {
        //Calls character select function
        CharacterSelect();
        //generates tiles
        _BoardGenerator.Generate();
    }
    private void CharacterSelect()
    //This function makes a while loop that awaits input to decide on what character the play wants to choose
    {
        int _i = 0;
        while (_i <= 3)
        {
            //Set Character to knight if you press 1
            if (Input.GetKeyUp(KeyCode.Alpha1))
            {
                _player[_i].SetJob(1);
                _i++;
            }
            //Set Character to rougue if you press 2
            else if (Input.GetKeyUp(KeyCode.Alpha2))
            {
                _player[_i].SetJob(2);
                _i++;
            }
            //Set Character to wizard if you press 3
            else if (Input.GetKeyUp(KeyCode.Alpha3))
            {
                _player[_i].SetJob(3);
                _i++;
            }

        }
    }

}
