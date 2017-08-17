using UnityEngine;
using System.Collections;
using System;
using System.IO;

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

		//Salvando json em arquivo
		var _arquivo = File.CreateText (Application.dataPath+"/"+"game.json");
		_arquivo.WriteLine (JsonUtility.ToJson(new Game("Teste","FPS")));
		_arquivo.Close();

		//Lendo arquivo de json
		var _arquivoJson = File.OpenText(Application.dataPath+"/"+"game.json");
		_game = JsonUtility.FromJson<Game> (_arquivoJson.ReadLine().ToString());
		_arquivoJson.Close ();
		print (_game.nome);
		print (_game.categoria);
		print (_game.lancamento);
	}	

	void Update () {}
}
