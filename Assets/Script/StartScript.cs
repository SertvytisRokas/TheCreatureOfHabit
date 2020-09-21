using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScript : MonoBehaviour
{
    public void toIntroMono1() {
        SceneManager.LoadScene("IntroMono");
    }

    public void toIntroMono2() {
        SceneManager.LoadScene("IntroMono2");
    }


    public void toIntro1()
    {
        SceneManager.LoadScene("Intro1");
    }
    public void toIntro2()
    {
        SceneManager.LoadScene("Intro2");
    }
    public void toIntro3()
    {
        SceneManager.LoadScene("Intro3");
    }
    public void toIntro4()
    {
        SceneManager.LoadScene("Intro4");
    }
    public void toIntro5()
    {
        SceneManager.LoadScene("Intro5");
    }
    public void toIntro6()
    {
        SceneManager.LoadScene("Intro6");
    }


    public void tolvl1Info() {
        SceneManager.LoadScene("lvl1Info");
    }
    public void toLevel1() {
        SceneManager.LoadScene("Level1");
    }



    public void toNarrator1() {
        SceneManager.LoadScene("Narrator1");
    }
    public void toNarrator2()
    {
        SceneManager.LoadScene("Narrator2");
    }
    public void toNarrator3()
    {
        SceneManager.LoadScene("Narrator3");
    }
    public void toNarrator4()
    {
        SceneManager.LoadScene("Narrator4");
    }
    public void toNarrator5()
    {
        SceneManager.LoadScene("Narrator5");
    }
    public void toNarrator6()
    {
        SceneManager.LoadScene("Narrator6");
    }
    public void toNarrator7()
    {
        SceneManager.LoadScene("Narrator7");
    }
    public void toNarrator8()
    {
        SceneManager.LoadScene("Narrator8");
    }






    public void toPostLvl1_1() {
        SceneManager.LoadScene("PostLvl1_1");
        Debug.Log("yeet");
    }

    public void toPostLvl1_2()
    {
        SceneManager.LoadScene("PostLvl1_2");
    }

    public void toPostLvl1_3()
    {
        SceneManager.LoadScene("PostLvl1_3");
    }

    public void toPostLvl1_4()
    {
        SceneManager.LoadScene("PostLvl1_4");
    }

    public void toPostLvl1_5()
    {
        SceneManager.LoadScene("PostLvl1_5");
    }

    public void toPostLvl1_6()
    {
        SceneManager.LoadScene("PostLvl1_6");
    }

    public void toLvl2Instructions() {
        SceneManager.LoadScene("Level2Instructions");
    }

    public void toLvl2() {
        SceneManager.LoadScene("Level2");
    }


    public void toCutscene2to3_1() {
        SceneManager.LoadScene("cutscene2to3_1");
    }
    public void toCutscene2to3_2() {
        SceneManager.LoadScene("cutscene2to3_2");
    }



    public void toLvl3Instructions() {
        SceneManager.LoadScene("Level3Instructions");
    }

    public void toLvl3() {
        SceneManager.LoadScene("Level3");
    }

    public void toCutscenefrom3_1() {
        SceneManager.LoadScene("PostLevel3Cutscenes");
    }

    public void toCutscenefrom3_2() {
        SceneManager.LoadScene("PostLevel3Cutscenes_2");
    }

    public void toGameEnd() {
        SceneManager.LoadScene("GameEnd");
    }

    










    public void toGameOver() {
        SceneManager.LoadScene("GameOver");
    }

    public void exitGame()
    {
        Application.Quit();
    }

    public void openSurvey() {
        Application.OpenURL("https://sprw.io/stt-5b98b6");
    }
}
