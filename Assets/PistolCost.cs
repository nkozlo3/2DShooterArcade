using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TMPro.EditorUtilities {
    public class PistolCost : MonoBehaviour
    {
        public TMP_Text pistolCost;

        // Update is called once per frame
        void Update()
        {
            pistolCost.text = PointSystemGameTwo.value.ToString();

        }
    }
}
