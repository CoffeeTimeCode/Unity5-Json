using UnityEngine;
using System.Collections;
using System;

public class UnityJson : MonoBehaviour {
	public Game _game;
	public string _json;

	void Start () {
		//Criando um json
		_game = new Game("Teste","Rpg");
		_json = JsonUtility.ToJson(_game);
		print (_json);
		//{"nome":"Teste","categoria":"Rpg","lancamento":"1/10/2017 6:04:44 PM"}

		//Lendo um json
		_game = JsonUtility.FromJson<Game>("{\"nome\":\"Teste\",\"categoria\":\"Rpg\",\"lancamento\":\"1/10/2017 6:04:44 PM\"}");
		print (_game.nome);
		print (_game.categoria);
		print (_game.lancamento);
	}	

	void Update () {}
}
