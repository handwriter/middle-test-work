using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShopUI : MonoBehaviour
{
    public TMP_Text levelValue;
    public TMP_Text moneyValue;
    private void OnEnable()
    {
        updateValues();
    }

    public void updateValues()
    {
        levelValue.text = Model.level.ToString();
        moneyValue.text = Model.money.ToString();
    }

    public void onUpgradeBtn()
    {
        if (Model.money >= 3)
        {
            Model.level += 1;
            Model.money -= 3;
            updateValues();
        }
    }

}
