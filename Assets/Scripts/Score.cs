using System.Drawing;
using UnityEngine;

public static class Score
{
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
