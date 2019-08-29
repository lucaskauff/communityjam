using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [Header("Serializable")]
    [SerializeField] GameManScript gameManager = default;

    [SerializeField] Animator daysPanel = default;
    [SerializeField] Animator hoursPanel = default;

    [SerializeField] GameObject playerDialogueBox = default;
    [SerializeField] SuperTextMesh playerDialogueText = default;
    [SerializeField] DistrictTemplate[] districts = default;

    private void Update()
    {
        PlayerDialogueManagement();
    }

    void PlayerDialogueManagement()
    {

        CheckDistrictsOnMap();

        if (playerDialogueText.text == string.Empty)
        {
            playerDialogueBox.gameObject.SetActive(false);
        }
        else
        {
            playerDialogueBox.gameObject.SetActive(true);
        }
    }

    void CheckDistrictsOnMap()
    {
        foreach (var district in districts)
        {
            if (district.isHighlighted)
            {
                playerDialogueText.text = district.districtName;
                return;
            }
        }

        playerDialogueText.text = "";
    }
}