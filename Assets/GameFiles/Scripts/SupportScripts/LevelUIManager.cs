using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class LevelUIManager : MonoBehaviour
{
    #region Properties
    public static LevelUIManager Instance = null;

    [Header("Attributes")]
    [SerializeField] private UIGameplayPhase activePhase = UIGameplayPhase.Phase_1;

    [Header("Gameplay UI Components Reference")]
    [SerializeField] private VariableJoystick movementJS = null;
    [SerializeField] private TextMeshProUGUI goldCountTxt = null;
    [SerializeField] private GameObject phase_1 = null;
    [SerializeField] private GameObject phase_2 = null;
    [SerializeField] private GameObject phase_3 = null;
    [SerializeField] private GameObject phase_4 = null;
    [SerializeField] private GameObject phase_5 = null;
    [SerializeField] private GameObject phase_6 = null;

    [Header("UI Panels")]
    [SerializeField] private GameObject victoryUI = null;
    [SerializeField] private GameObject failUI = null;

    [Header("Phase 2 Components Reference")]
    [SerializeField] private Image purityCheckBar = null;
    [SerializeField] private Image temperaturePB = null;
    [SerializeField] private GameObject purityPBObj = null;
    [SerializeField] private GameObject meltingMechUI = null;
    [SerializeField] private GameObject freezeBtn = null;
    #endregion

    #region MonoBehaviour Functions
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        Instance = this;
    }

    private void Start()
    {
        SwitchGameplayUIPhase(activePhase);
    }
    #endregion

    #region Getter And Setter
    public VariableJoystick GetMovementJS { get => movementJS; }
    #endregion

    #region Btn Events Functions
   
    #endregion

    #region Private Core Functions
    private void SwitchGameplayUIPhase(UIGameplayPhase phase)
    {
        switch (phase)
        {
            case UIGameplayPhase.Phase_1:
                phase_1.SetActive(true);
                phase_2.SetActive(false);
                phase_3.SetActive(false);
                phase_4.SetActive(false);
                phase_5.SetActive(false);
                phase_6.SetActive(false);
                break;
            case UIGameplayPhase.Phase_2:
                phase_1.SetActive(false);
                phase_2.SetActive(true);
                phase_3.SetActive(false);
                phase_4.SetActive(false);
                phase_5.SetActive(false);
                phase_6.SetActive(false);
                break;
            case UIGameplayPhase.Phase_3:
                phase_1.SetActive(false);
                phase_2.SetActive(false);
                phase_3.SetActive(true);
                phase_4.SetActive(false);
                phase_5.SetActive(false);
                phase_6.SetActive(false);
                break;
            case UIGameplayPhase.Phase_4:
                phase_1.SetActive(false);
                phase_2.SetActive(false);
                phase_3.SetActive(false);
                phase_4.SetActive(true);
                phase_5.SetActive(false);
                phase_6.SetActive(false);
                break;
            case UIGameplayPhase.Phase_5:
                phase_1.SetActive(false);
                phase_2.SetActive(false);
                phase_3.SetActive(false);
                phase_4.SetActive(false);
                phase_5.SetActive(true);
                phase_6.SetActive(false);
                break;
            case UIGameplayPhase.Phase_6:
                phase_1.SetActive(false);
                phase_2.SetActive(false);
                phase_3.SetActive(false);
                phase_4.SetActive(false);
                phase_5.SetActive(false);
                phase_6.SetActive(true);
                break;
            case UIGameplayPhase.None:
                phase_1.SetActive(false);
                phase_2.SetActive(false);
                phase_3.SetActive(false);
                phase_4.SetActive(false);
                phase_5.SetActive(false);
                phase_6.SetActive(false);
                break;
        }
    }
    #endregion

    #region Public Core Functions

   
    #endregion
}
