#pragma strict
public var _game: Game;
public var _json: String;

function Start () {
	_game = new Game("Teste","Rpg");
	_json = JsonUtility.ToJson(_game);
	print(_json);
}

function Update () {}
