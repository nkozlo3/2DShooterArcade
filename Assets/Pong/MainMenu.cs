using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public static float whichClick = 0f;
    public static float whichLevel = 0f;
    public static string whichClickString = "";
    public static bool powerMode = false;
    public static string whichGun;
    void Awake()
    {
        DontDestroyOnLoad(this);
    }
    //called when clicked
    public void GameMode() {
        whichClick = -1f;
        SceneManager.LoadScene(1);
    }
    public void BackToMenu() {
        whichClick = -1f;
        SceneManager.LoadScene (0);
    }
    public void Runner()
    {
        whichClick = -1f;
        SceneManager.LoadScene(9);
    }
    public void MusicMenu() {
        whichClick = -1f;
        SceneManager.LoadScene(3);
    }

    public void clickedPowerUp() {
        powerMode = true;
        whichClick = 6f;
        SceneManager.LoadScene(2);
    }
    public void clickedGameTwoLevel1()
    {
        whichLevel = 1f;
        whichClick = -1f;
        SceneManager.LoadScene(6);
    }
    public void clickedGameTwoLevel2()
    {
        whichLevel = 2f;
        whichClick = -1f;
        SceneManager.LoadScene(6);
    }
    public void clickedOnPistolCharacter()
    {

        whichGun = "Pistol";
        whichClick = -1f;
        if (whichLevel == 1f)
            SceneManager.LoadScene(7);
        if (whichLevel == 2f)
            SceneManager.LoadScene(8);
    }
    public void clickedOnMGCharacter()
    {
        whichGun = "MG";
        if (whichLevel == 1f)
            SceneManager.LoadScene(7);
        if (whichLevel == 2f)
            SceneManager.LoadScene(8);
    }
    public void clickedNeedToRelax() {
        whichClick = -7f;
        // FindObjectOfType<AudioManager>().Stop("Minecraft");
        // FindObjectOfType<AudioManager>().Stop("Chopin");
        // FindObjectOfType<AudioManager>().Stop("Wonderland");
        // FindObjectOfType<AudioManager>().Stop("Violin");
        // FindObjectOfType<AudioManager>().Stop("TroubleMan");
        // FindObjectOfType<AudioManager>().Stop("HighHopes");
        // FindObjectOfType<AudioManager>().Play("MusicRelax");
        SceneManager.LoadScene(4);
    }
    public void clickedBoredOfPong() {
        whichClick = -1f;
        SceneManager.LoadScene(5);
    }


    public void clickedDifOne() {
        whichClick = 5f;
        var temp = new EnemyPaddle();
        temp.enemySpeed = 5f;
        SceneManager.LoadScene(2);
    }

    public void clickedDifTwo() {
        whichClick = 8f;
        var temp = new EnemyPaddle();
        temp.enemySpeed = 8f;
        SceneManager.LoadScene(2);
    }
    public void clickedDifThree() {
        whichClick = 12f;
        var temp = new EnemyPaddle();
        temp.enemySpeed = 12f;
        SceneManager.LoadScene(2);
    }
    public void clickedDifFour() {
        whichClick = 16f;
        var temp = new EnemyPaddle();
        temp.enemySpeed = 16f;
        SceneManager.LoadScene(2);
    }
    public void PlayMinecraftMisc() {
        FindObjectOfType<AudioManager>().Stop("TroubleMan");
        FindObjectOfType<AudioManager>().Stop("Chopin");
        FindObjectOfType<AudioManager>().Stop("Wonderland");
        FindObjectOfType<AudioManager>().Stop("Violin");
        FindObjectOfType<AudioManager>().Stop("HighHopes");
        FindObjectOfType<AudioManager>().Stop("MusicRelax");
        FindObjectOfType<AudioManager>().Stop("PowerUp");
        FindObjectOfType<AudioManager>().Play("Minecraft");
    }
    public void PowerUp()
    {
        FindObjectOfType<AudioManager>().Stop("TroubleMan");
        FindObjectOfType<AudioManager>().Stop("Chopin");
        FindObjectOfType<AudioManager>().Stop("Wonderland");
        FindObjectOfType<AudioManager>().Stop("Violin");
        FindObjectOfType<AudioManager>().Stop("HighHopes");
        FindObjectOfType<AudioManager>().Stop("MusicRelax");
        FindObjectOfType<AudioManager>().Stop("Minecraft");
        FindObjectOfType<AudioManager>().Play("PowerUp");
    }
    public void PlayTroubleManMusic() {
        FindObjectOfType<AudioManager>().Stop("Minecraft");
        FindObjectOfType<AudioManager>().Stop("Chopin");
        FindObjectOfType<AudioManager>().Stop("Wonderland");
        FindObjectOfType<AudioManager>().Stop("Violin");
        FindObjectOfType<AudioManager>().Stop("HighHopes");
        FindObjectOfType<AudioManager>().Stop("MusicRelax");
        FindObjectOfType<AudioManager>().Stop("PowerUp");
        FindObjectOfType<AudioManager>().Play("TroubleMan");
    }
    public void PlayChopin() {
        FindObjectOfType<AudioManager>().Stop("Minecraft");
        FindObjectOfType<AudioManager>().Stop("TroubleMan");
        FindObjectOfType<AudioManager>().Stop("Wonderland");
        FindObjectOfType<AudioManager>().Stop("Violin");
        FindObjectOfType<AudioManager>().Stop("HighHopes");
        FindObjectOfType<AudioManager>().Stop("MusicRelax");
        FindObjectOfType<AudioManager>().Stop("PowerUp");
        FindObjectOfType<AudioManager>().Play("Chopin");
    }
    public void PlayWonderland() {
        FindObjectOfType<AudioManager>().Stop("Minecraft");
        FindObjectOfType<AudioManager>().Stop("Chopin");
        FindObjectOfType<AudioManager>().Stop("TroubleMan");
        FindObjectOfType<AudioManager>().Stop("Violin");
        FindObjectOfType<AudioManager>().Stop("HighHopes");
        FindObjectOfType<AudioManager>().Stop("MusicRelax");
        FindObjectOfType<AudioManager>().Play("Wonderland");
    }
    public void PlayViolin() {
        FindObjectOfType<AudioManager>().Stop("Minecraft");
        FindObjectOfType<AudioManager>().Stop("Chopin");
        FindObjectOfType<AudioManager>().Stop("Wonderland");
        FindObjectOfType<AudioManager>().Stop("TroubleMan");
        FindObjectOfType<AudioManager>().Stop("HighHopes");
        FindObjectOfType<AudioManager>().Stop("MusicRelax");
        FindObjectOfType<AudioManager>().Stop("PowerUp");
        FindObjectOfType<AudioManager>().Play("Violin");
    }
    public void HighHopes() {
        FindObjectOfType<AudioManager>().Stop("Minecraft");
        FindObjectOfType<AudioManager>().Stop("Chopin");
        FindObjectOfType<AudioManager>().Stop("Wonderland");
        FindObjectOfType<AudioManager>().Stop("Violin");
        FindObjectOfType<AudioManager>().Stop("TroubleMan");
        FindObjectOfType<AudioManager>().Stop("MusicRelax");
        FindObjectOfType<AudioManager>().Stop("PowerUp");
        FindObjectOfType<AudioManager>().Play("HighHopes");
    }
    public void ClickedNeedToRelaxMusic() {
        FindObjectOfType<AudioManager>().Stop("Minecraft");
        FindObjectOfType<AudioManager>().Stop("Chopin");
        FindObjectOfType<AudioManager>().Stop("Wonderland");
        FindObjectOfType<AudioManager>().Stop("Violin");
        FindObjectOfType<AudioManager>().Stop("TroubleMan");
        FindObjectOfType<AudioManager>().Stop("HighHopes");
        FindObjectOfType<AudioManager>().Stop("PowerUp");
        FindObjectOfType<AudioManager>().Play("MusicRelax");
    }
}
