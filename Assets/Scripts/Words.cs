using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Words : MonoBehaviour
{
    //array of possible words
    public static string[] words = 
    {
        "mug",
        "show",
        "beg",
        "van",
        "puzzled",
        "zinc",
        "egg",
        "confess",
        "fallacious",
        "mask",
        "discovery",
        "drown",
        "mist",
        "ray",
        "typical",
        "pest",
        "camp",
        "mix",
        "jewel",
        "jellyfish",
        "drab",
        "knotty",
        "towering",
        "educated",
        "develop",
        "flowery",
        "true",
        "letter",
        "permissible",
        "sail",
        "ugly",
        "standing",
        "paltry",
        "men",
        "pause",
        "suppose",
        "celery",
        "pocket",
        "vagabond",
        "waiting",
        "rabbit",
        "next",
        "zippy",
        "bear",
        "zonked",
        "spiteful",
        "reduce",
        "sister",
        "open" 
    };

    public static string GetWord()
    {
        string word= words[Random.Range(0,words.Length)];
        return word;

    }

}
