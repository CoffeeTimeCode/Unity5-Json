using UnityEngine;
using System.Collections;
using System;

public class Game {
	public string nome;
	public string categoria;
	public string lancamento;

	public Game(string nome, string categoria){
		this.nome = nome;
		this.categoria = categoria;
		this.lancamento = DateTime.Now.ToString();
	}
}
