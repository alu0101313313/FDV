using System.Drawing;
using UnityEngine;

public static class Score
{
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
	private static void restart()
	{
		score = 0;
		Debug.Log("Restart score: 0");
	}
	
	public static int score { get; private set; }

	public static void Up(int points)
	{
		score += points;
		Debug.Log($"Score: {score} (+{points})");
	}

	public static void Down(int points)
	{
		score -= points;
		Debug.Log($"Score: {score} (-{points})");
	}
}
