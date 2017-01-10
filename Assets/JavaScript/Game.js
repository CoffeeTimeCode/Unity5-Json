#pragma strict

public class Game{
	public var nome: String;
	public var categoria: String;
	public var lancamento: String;
	
	public function Game(nome: String, categoria: String){
		this.nome = nome;
		this.categoria = categoria;
		this.lancamento = new Date().Now.ToString();
	}
}