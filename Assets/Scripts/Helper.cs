using UnityEngine;
using System.Collections;

namespace HelperStuffs {
	public static class Helper
	{
		public static DecorFactory getDecorFactory()
		{
			return GameObject.FindObjectOfType<DecorFactory>();
		}

		public static GameManager getGameManager()
		{
			return GameObject.FindObjectOfType<GameManager>();
		}

		public static Moveable[] getMoveables()
		{
			return GameObject.FindObjectsOfType<Moveable>();
		}
	}

}
