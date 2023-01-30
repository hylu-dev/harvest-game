using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState : MonoBehaviour
{
    public static int moral { get; set; }
    public static bool helped_mal { get; set; }
    public static bool helped_cass { get; set; }
    public static bool has_book { get; set; }
    public static bool has_money { get; set; }
    public static bool has_food { get; set; }
    public static bool overtime { get; set; }

    private void Awake() {
        moral = 0;
        helped_mal = false;
        helped_cass = false;
        has_book = false;
        has_money = false;
        has_food = false;
        overtime = false;
    }
}
