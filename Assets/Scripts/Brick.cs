using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

    public int maxHits;
    private int timesHit;
    private LevelManager levelManager;
    public Sprite[] hitSprites;
	// Use this for initialization
	void Start ()
    {
        levelManager = GameObject.FindObjectOfType<LevelManager>();
        timesHit = 0;
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        timesHit++;
        if (timesHit >= maxHits)
        {
            Destroy(gameObject);
        }
        else
        {
            LoadSprites();
        }
    }

    private void LoadSprites()
    {
        int spriteIndex = timesHit - 1;
        this.GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
    }

    private void SimulateWin()
    {
        levelManager.LoadNextLevel();
    }
}
