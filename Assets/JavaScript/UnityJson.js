#pragma strict
import System.IO;

public var _game: Game;
public var _json: String;

function Start () {
	//Criando um json
	_game = new Game("Teste","Rpg");
	_json = JsonUtility.ToJson(_game);
	print(_json);
	
	//Lendo um json
	_game = JsonUtility.FromJson("{\"nome\":\"Teste\",\"categoria\":\"Rpg\",\"lancamento\":\"1/10/2017 6:04:44 PM\"}",Game);
	print (_game.nome);
	print (_game.categoria);
	print (_game.lancamento);
	
	//Salvando json em arquivo
	var _arquivo = File.CreateText (Application.dataPath+"/"+"game.json");
	_arquivo.WriteLine (JsonUtility.ToJson(new Game("Teste","FPS")));
	_arquivo.Close();
	
	//Lendo arquivo de json
	var _arquivoJson = File.OpenText(Application.dataPath+"/"+"game.json");
	_game = JsonUtility.FromJson(_arquivoJson.ReadLine().ToString(),Game);
	_arquivoJson.Close ();
	print (_game.nome);
	print (_game.categoria);
	print (_game.lancamento);
}

function Update () {}
