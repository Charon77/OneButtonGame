using UnityEngine;
using System.Collections;

namespace HelperStuffs {
	public static class Helper
	{
		public static DecorFactory getDecorFactory()
		{
			return GameObject.FindObjectOfType<DecorFactory>();
		}

		public static EnemyFactory getEnemyFactory()
		{
			return GameObject.FindObjectOfType<EnemyFactory>();
		}

		public static GameManager getGameManager()
		{
			return GameObject.FindObjectOfType<GameManager>();
		}

		public static Moveable[] getMoveables()
		{
			return GameObject.FindObjectsOfType<Moveable>();
		}
		public static void KillAllGameManagers()
		{
			var gameManagers = GameObject.FindObjectsOfType<GameManager>();
			foreach (var gameManager in gameManagers) {
				gameManager.Kill();	
			}
		}
	}

}
