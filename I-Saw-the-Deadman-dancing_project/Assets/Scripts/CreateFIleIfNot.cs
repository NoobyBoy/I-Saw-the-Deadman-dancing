using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateFIleIfNot : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        System.IO.FileStream IoFileStream = new System.IO.FileStream("YesYouDidIt.congratulation", System.IO.FileMode.OpenOrCreate);
    }

}
