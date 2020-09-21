using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public enum BattleState { START, PLAYERTURN, ENEMYTURN, WON, LOST }
public enum AIState { ATTACK, HEAL }


public class BattleSystem : MonoBehaviour
{


    // Stage 1
    public GameObject playerPrefab;
    public GameObject enemyPrefab;

    public Transform playerBattleStation;
    public Transform enemyBattleStation;

    Unit playerUnit;
    public static Unit enemyUnit;
    Unit madRolloUnit;

    public Text dialogueText;

    public BattleHUD playerHUD;
    public BattleHUD enemyHUD;

    public BattleState state;
    public AIState stateAI;

    bool AISuccess;
    bool PlayerSuccess;

    public int keyPlayer;
    int key;

    int healValue;

    // Stage 2

    public GameObject support1Prefab;
    public GameObject support2Prefab;

    Unit support1Unit;
    Unit support2Unit;

    public Transform support1BattleStation;
    public Transform support2BattleStation;

    public static bool stage2;
    int stage2Counter = 0;

    public GameObject stage2Display;

    // Movement

    public GameObject[] waypoints;
    int currentPosition;
    float rotSpeed;
    public float speed;
    float WPradius = 1;

    bool playerAttacking;

    float offset;

    // Cutscene

    public GameObject dialog1;
    public GameObject dialog2;
    public GameObject dialog3;
    public GameObject dialog4;
    public GameObject dialog5;

    public GameObject cutsceneBackground;

    int buttonCounter = 0;

    //public GameObject aura;

    int rolloPowerUpCounter = 0;


    // Rollo Mad Cutscene

    public GameObject dialog6;
    public GameObject dialog7;

    public GameObject cutsceneAura;
    public GameObject rolloMadBackground;
    int rolloMadButtonCounter = 0;

    bool isRolloMad;
    public GameObject rolloAura;

    public GameObject madRolloPrefab;


    // Damage Effects

    public Text rolloDamage;
    public Text creatureDamage;

    public GameObject rolloDamageObject;
    public GameObject creatureDamageObject;

    // Battle Audio

    public AudioSource source1;
    public AudioSource source2;

    int musicUpdateCounter = 0;


    GameObject rolloCopy;

    public Button attackButton;
    public Button healButton;

    void Start()
    {
        state = BattleState.START;
        StartCoroutine(SetupBattle());

        stage2Display.SetActive(false);

        cutsceneBackground.SetActive(false);
        dialog1.SetActive(false);
        dialog2.SetActive(false);
        dialog3.SetActive(false);
        dialog4.SetActive(false);
        dialog5.SetActive(false);

        dialog6.SetActive(false);
        dialog7.SetActive(false);
        cutsceneAura.SetActive(false);
        rolloMadBackground.SetActive(false);

        rolloDamageObject.SetActive(false);
        creatureDamageObject.SetActive(false);



    }

    private void Update()
    {
        if (isRolloMad)
        {
            rolloAura.SetActive(true);
        }
        else {
            rolloAura.SetActive(false);
        }

        
        if (stage2 == true) {
            inputCounter();
            cutsceneController();
        }
        if (isRolloMad == true) {

            rolloMadInputCounter();
            rolloMadCutsceneController();
        }

        loadScene();

    }

    void PlayerAttackAnimation() {

        offset += Time.deltaTime;

    }



    IEnumerator SetupBattle()
    {

        GameObject playerGO = Instantiate(playerPrefab, playerBattleStation);
        playerUnit = playerGO.GetComponent<Unit>();

        GameObject enemyGO = Instantiate(enemyPrefab, enemyBattleStation);
        enemyUnit = enemyGO.GetComponent<Unit>();

        dialogueText.text = "A wild " + enemyUnit.unitName + " has appeared!";

        playerHUD.SetHUD(playerUnit);
        enemyHUD.SetHUD(enemyUnit);

        yield return new WaitForSeconds(2f);

        state = BattleState.PLAYERTURN;
        PlayerTurn();

    }

    void PlayerTurn()
    {

        dialogueText.text = "Choose an action";

    }

    void EndBattle()
    {

        if (state == BattleState.WON)
        {
            dialogueText.text = "Congratulations, you won! ";

        }
        else
        {

            dialogueText.text = " You have been defeated! ";


        }

    }

    void loadScene() {
        if (state == BattleState.WON || state == BattleState.LOST)
        {
            SceneManager.LoadScene("Level3Win");
        }
    }
    IEnumerator PlayerAttack()
    {
        if (enemyUnit.currentHP <= 25)
        {
            isRolloMad = true;
        }
        PlayerAttackSuccess();
        if (PlayerSuccess)
        {
            playerAttacking = true;
            keyPlayer = Random.Range(1, 100);

            if (stage2 == true) {
                keyPlayer = 21;
            }



            if (keyPlayer < 20)
            {
                bool isDead = enemyUnit.TakeDamage(playerUnit.damage + playerUnit.damage / 2);
                float tempValue = playerUnit.damage + playerUnit.damage / 2;
                enemyHUD.setHP(enemyUnit.currentHP);
                dialogueText.text = "You delivered a CRITICAL HIT of " + tempValue + " points!";
                dialogueText.color = new Color(252.0f / 255.0f, 33.0f / 255.0f, 33.0f / 255.0f);
                rolloDamageObject.SetActive(true);
                rolloDamage.color = new Color(252.0f / 255.0f, 33.0f / 255.0f, 33.0f / 255.0f);
                rolloDamage.text = "- " + tempValue + " HP";

                StartCoroutine(turnOffDamage());

                yield return new WaitForSeconds(2f);

                dialogueText.color = new Color(0f / 255.0f, 0f / 255.0f, 0f / 255.0f);
                if (isDead)
                {
                    state = BattleState.WON;
                    EndBattle();
                }
                else
                {

                    state = BattleState.ENEMYTURN;
                    StartCoroutine(EnemyTurn());

                }
            }
            else
            {
                bool isDead = enemyUnit.TakeDamage(playerUnit.damage);
                enemyHUD.setHP(enemyUnit.currentHP);
                dialogueText.text = "Successful attack! Rollo lost " + playerUnit.damage + " HP!";
                rolloDamageObject.SetActive(true);
                rolloDamage.color = new Color(252.0f / 255.0f, 33.0f / 255.0f, 33.0f / 255.0f);
                rolloDamage.text = "- " + playerUnit.damage + " HP";
                StartCoroutine(turnOffDamage());

                yield return new WaitForSeconds(2f);

                if (isDead)
                {
                    state = BattleState.WON;
                    EndBattle();
                }
                else
                {

                    state = BattleState.ENEMYTURN;
                    StartCoroutine(EnemyTurn());

                }
            }


        }
        else {
            playerAttacking = false;
            dialogueText.text = playerUnit.unitName + " attack was unsuccessful";
            yield return new WaitForSeconds(2f);
            state = BattleState.ENEMYTURN;
            StartCoroutine(EnemyTurn());

        }
    }

    void AIAttackSuccess() {
        key = Random.Range(1, 100);
        if (stage2 == true)
        {
            if (key <= 95)
            {
                AISuccess = true;
            }
            else
            {
                AISuccess = false;
            }
        }
        else
        {
            if (key <= 85)
            {
                AISuccess = true;
            }
            else
            {
                AISuccess = false;
            }
        }
    }

    void PlayerAttackSuccess() {
        key = Random.Range(1, 100);
        if (key <= 95)
        {
            PlayerSuccess = true;
        }
        else {
            PlayerSuccess = false;
        }
    }

    IEnumerator EnemyTurn()
    {
        AIDecision();
        if (enemyUnit.currentHP <= 25)
        {
            isRolloMad = true;
        }

        if (stateAI == AIState.ATTACK)
        {
            dialogueText.text = enemyUnit.unitName + "Attacks!";

            AIAttackSuccess();
            if (AISuccess)
            {
                key = Random.Range(1, 100);

                if (key >= 75)
                {
                    bool isDead = playerUnit.TakeDamage(enemyUnit.damage + enemyUnit.damage / 2);
                    float tempValue = enemyUnit.damage + enemyUnit.damage / 2;
                    yield return new WaitForSeconds(1f);
                    dialogueText.color = new Color(252.0f / 255.0f, 33.0f / 255.0f, 33.0f / 255.0f);
                    dialogueText.text = "Oh no, that's a CRITICAL HIT! You lost " + tempValue + " HP!";
                    creatureDamageObject.SetActive(true);
                    creatureDamage.color = new Color(252.0f / 255.0f, 33.0f / 255.0f, 33.0f / 255.0f);
                    creatureDamage.text = "- " + tempValue + " HP";

                    StartCoroutine(turnOffDamage());

                    playerHUD.setHP(playerUnit.currentHP);

                    if (playerUnit.currentHP <= 23)
                    {
                        StartCoroutine(startStage2());
                    }

                    yield return new WaitForSeconds(2f);
                    dialogueText.color = new Color(0f / 255.0f, 0f / 255.0f, 0f / 255.0f);
                    if (isDead)
                    {
                        state = BattleState.LOST;
                        EndBattle();
                    }
                    else
                    {
                        state = BattleState.PLAYERTURN;
                        PlayerTurn();
                    }

                }
                else
                {

                    yield return new WaitForSeconds(1f);
                    bool isDead = playerUnit.TakeDamage(enemyUnit.damage);
                    dialogueText.text = "You lost " + enemyUnit.damage + " HP!";
                    creatureDamageObject.SetActive(true);
                    creatureDamage.color = new Color(252.0f / 255.0f, 33.0f / 255.0f, 33.0f / 255.0f);
                    creatureDamage.text = "- " + enemyUnit.damage + " HP";


                    playerHUD.setHP(playerUnit.currentHP);
                    StartCoroutine(turnOffDamage());
                    if (playerUnit.currentHP <= 23)
                    {
                        StartCoroutine(startStage2());
                    }

                    yield return new WaitForSeconds(1f);

                    if (isDead)
                    {
                        state = BattleState.LOST;
                        EndBattle();
                    }
                    else
                    {
                        state = BattleState.PLAYERTURN;
                        PlayerTurn();
                    }
                }
            }
            else {

                dialogueText.text = enemyUnit.unitName + " attack was unsuccessful";
                yield return new WaitForSeconds(2f);
                state = BattleState.PLAYERTURN;
                PlayerTurn();

            }
        }
        else
        {
            healAmountAI();
            dialogueText.text = enemyUnit.unitName + " has healed by " + healValue + " points";
            enemyUnit.Heal(healValue);
            enemyHUD.setHP(enemyUnit.currentHP);
            rolloDamageObject.SetActive(true);
            rolloDamage.color = Color.green;
            rolloDamage.text = "+ " + healValue + " HP";
            StartCoroutine(turnOffDamage());


            yield return new WaitForSeconds(2f);

            state = BattleState.PLAYERTURN;
            PlayerTurn();
        }
    }

    void healAmountAI()
    {
        key = Random.Range(1, 100);
        if (stage2 == true) {
            key = 29;
        }
        if (key >= 30)
        {
            healValue = 15;
        }
        else
        {
            healValue = 20;
        }
    }

    void healAmountPlayer() {
        key = Random.Range(1, 100);
        if (stage2 == true) {
            key = 31;
        }
        if (key >= 30)
        {
            healValue = 10;
        }
        else {
            healValue = 25;
        }
    }

    void AIDecision()
    {
        if (enemyUnit.currentHP >= 70)
        {
            stateAI = AIState.ATTACK;
        }
        else if (enemyUnit.currentHP > 20 && enemyUnit.currentHP < 70)
        {
            key = Random.Range(1, 100);
            if (key >= 75)
            {
                stateAI = AIState.HEAL;
            }
            else
            {
                stateAI = AIState.ATTACK;

            }
        }
        else
        {
            key = Random.Range(1, 100);
            if (key >= 80)
            {
                stateAI = AIState.ATTACK;
            }
            else
            {
                stateAI = AIState.HEAL;
            }
        }
    }

        IEnumerator PlayerHeal()
        {
            healAmountPlayer();
            playerUnit.Heal(healValue);

            playerHUD.setHP(playerUnit.currentHP);
            dialogueText.text = "Creature has healed by " + healValue + " points!";
            creatureDamageObject.SetActive(true);
            creatureDamage.color = Color.green;
            creatureDamage.text = "+ " + healValue + " HP";
            StartCoroutine(turnOffDamage());

            yield return new WaitForSeconds(2f);

            state = BattleState.ENEMYTURN;
            StartCoroutine(EnemyTurn());

        }

        public void OnAttackButton()
        {

            if (state != BattleState.PLAYERTURN)
            {
                return;
            }

            StartCoroutine(PlayerAttack());

        }

        public void OnHealButton()
        {

            if (state != BattleState.PLAYERTURN)
            {
                return;
            }

            StartCoroutine(PlayerHeal());

        }

        public void updateRollo() {
            GameObject madRolloObject = Instantiate(madRolloPrefab, enemyBattleStation);
            madRolloUnit = madRolloObject.GetComponent<Unit>();
            enemyUnit = madRolloUnit;
            enemyHUD.setHP(enemyUnit.currentHP);
            Destroy(enemyPrefab);
        }
        IEnumerator startStage2() {

            GameObject support1GO = Instantiate(support1Prefab, support1BattleStation);
            support1Unit = support1GO.GetComponent<Unit>();


            GameObject support2GO = Instantiate(support2Prefab, support2BattleStation);
            support2Unit = support2GO.GetComponent<Unit>();

            Debug.Log("heeeeeya");

            stage2Counter++;
            stage2 = true;
            updateVariables();
            yield return new WaitForSeconds(2f);
            StartCoroutine(stage2Label());
            dialogueText.text = "Reinforcements have arrived!";
            if (stage2Counter < 2) {

                source1.Stop();
                //Destroy(source1);

                source2.Play();
            }

            state = BattleState.PLAYERTURN;
            PlayerTurn();
        }

        void RolloPowerUp() {
            rolloPowerUpCounter++;
        if (rolloPowerUpCounter == 1)
        {
            //aura.SetActive(true);
            enemyUnit.currentHP = 100;
            enemyHUD.setHP(enemyUnit.currentHP);
            enemyUnit.damage = enemyUnit.damage * 5 / 2;
            enemyPrefab.GetComponent<SpriteRenderer>().color = new Color(231.0f / 255.0f, 173.0f / 255.0f, 173.0f / 255.0f);
            // updateRollo();
        }
        else {
            rolloPowerUpCounter = 5;
        }
        }

        void updateVariables() {
            if (stage2 == true && stage2Counter == 1) {
                playerUnit.Heal(50);
                playerHUD.setHP(playerUnit.currentHP);
                enemyHUD.setHP(enemyUnit.currentHP);
                playerUnit.damage = playerUnit.damage * 7 / 3;

            }
        }

        void unclockButton() {
            if (dialogueText.text.Equals("Choose an action"))
            {
                attackButton.interactable = true;
                healButton.interactable = true;
            }
            else {
                attackButton.interactable = false;
                healButton.interactable = false;
            }
        }

        IEnumerator stage2Label() {
            if (stage2 == true) {

                if (stage2Display != null)
                {
                    stage2Display.SetActive(true);
                }
                yield return new WaitForSeconds(2f);
                Destroy(stage2Display);


            }
        }


        void inputCounter() {
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                buttonCounter++;
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                buttonCounter--;
            }
        }

        public void cutsceneController() {

            if (buttonCounter < 0 || buttonCounter == 0) {
                buttonCounter = 0;
                cutsceneBackground.SetActive(true);
            }

            if (buttonCounter == 1) {
                dialog1.SetActive(true);
                dialog2.SetActive(false);
                dialog3.SetActive(false);
                dialog4.SetActive(false);
                dialog5.SetActive(false);
                cutsceneBackground.SetActive(true);
            }

            if (buttonCounter == 2)
            {
                dialog1.SetActive(false);
                dialog2.SetActive(true);
                dialog3.SetActive(false);
                dialog4.SetActive(false);
                dialog5.SetActive(false);
            }

            if (buttonCounter == 3)
            {
                dialog1.SetActive(false);
                dialog2.SetActive(false);
                dialog3.SetActive(true);
                dialog4.SetActive(false);
                dialog5.SetActive(false);
            }

            if (buttonCounter == 4)
            {
                dialog1.SetActive(false);
                dialog2.SetActive(false);
                dialog3.SetActive(true);
                dialog4.SetActive(true);
                dialog5.SetActive(false);
            }

            if (buttonCounter == 5)
            {
                dialog1.SetActive(false);
                dialog2.SetActive(false);
                dialog3.SetActive(false);
                dialog4.SetActive(false);
                dialog5.SetActive(true);
                cutsceneBackground.SetActive(true);
            }

            if (buttonCounter == 6) {
                dialog1.SetActive(false);
                dialog2.SetActive(false);
                dialog3.SetActive(false);
                dialog4.SetActive(false);
                dialog5.SetActive(false);
                cutsceneBackground.SetActive(true);

            }
            if (buttonCounter > 6)
            {
                dialog1.SetActive(false);
                dialog2.SetActive(false);
                dialog3.SetActive(false);
                dialog4.SetActive(false);
                dialog5.SetActive(false);
                cutsceneBackground.SetActive(false);



                buttonCounter = 7;
            }
        }

        void rolloMadInputCounter() {
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                rolloMadButtonCounter++;
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                rolloMadButtonCounter--;
            }
        }

        public void rolloMadCutsceneController() {
            enemyUnit.Heal(100 - enemyUnit.currentHP);
            enemyHUD.setHP(enemyUnit.currentHP);
            if (rolloMadButtonCounter <= 0) {
                rolloMadButtonCounter = 0;
                rolloMadBackground.SetActive(true);
                //Debug.Log("step 0");
            }

            if (rolloMadButtonCounter == 1) {
                dialog6.SetActive(true);
                dialog7.SetActive(false);
                cutsceneAura.SetActive(false);
                rolloMadBackground.SetActive(true);
                // Debug.Log("step 1");
            }

            if (rolloMadButtonCounter == 2) {
                dialog6.SetActive(false);
                dialog7.SetActive(true);
                cutsceneAura.SetActive(true);
                rolloMadBackground.SetActive(true);
                //Debug.Log("step 2");
            }

            if (rolloMadButtonCounter == 3) {
                dialog6.SetActive(false);
                dialog7.SetActive(false);
                cutsceneAura.SetActive(true);
                rolloMadBackground.SetActive(true);
                //Debug.Log("step 3");
            }
            if (rolloMadButtonCounter > 3) {
                dialog6.SetActive(false);
                dialog7.SetActive(false);
                cutsceneAura.SetActive(false);
                rolloMadBackground.SetActive(false);
                //Debug.Log("step 4");
                rolloMadButtonCounter = 4;
            
                RolloPowerUp();
            }
        }

        IEnumerator turnOffDamage() {
            yield return new WaitForSeconds(1f);
            rolloDamageObject.SetActive(false);
            creatureDamageObject.SetActive(false);
        }
    }

