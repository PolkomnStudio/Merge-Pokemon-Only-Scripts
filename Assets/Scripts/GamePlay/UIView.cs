using TMPro;
using UnityEngine;

namespace GamePlay
{
    public class UIView : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _totalKillText;
        [SerializeField] private TextMeshProUGUI _bulletsText;
        [SerializeField] private TextMeshProUGUI _scanerCDText;
        [SerializeField] private GameObject GameOverPanel;

        public int _totalKillCount { private set; get; } = 0;

        private void OnEnable()
        {
            Enemy.EnemyDisable += TotalKillAdd;
            PlayerBulletBank.BulletsValue += Bullets;
            ScanerController.CDTimerValue += ScanerCD;
            Enemy.EnemyFinish += GameOverVisible;
        }

        private void OnDisable()
        {
            Enemy.EnemyDisable -= TotalKillAdd;
            PlayerBulletBank.BulletsValue -= Bullets;
            ScanerController.CDTimerValue -= ScanerCD;
            Enemy.EnemyFinish -= GameOverVisible;
        }

        private void GameOverVisible()
        {
            Time.timeScale = 0f;
            GameOverPanel.SetActive(true);
        }

        private void GameOverInvsible()
        {
            Time.timeScale = 1f;
            GameOverPanel.SetActive(false);
        }

        private void TotalKillAdd()
        {
            _totalKillCount++;
            TotalKillTextUpdate();
        }

        private void TotalKillTextUpdate()
        {
            _totalKillText.text = "Totat Kill: "+ _totalKillCount.ToString();
        }

        private void Bullets(int value)
        {
            _bulletsText.text = value.ToString();
        }

        private void ScanerCD(int value)
        {
            _scanerCDText.text = value.ToString();
            if (value == 0)
            {
                _scanerCDText.text = "";
            }
        }
    }
}

