class carinho{
  private string cltdono;
  private string itens;
  private int qtditens;
  public int total;
  public int codigo;
  public double preco;


  
  cliente novoCliente = new cliente();
  public void Setcltdono(string clt ){
    cltdono=clt;
  }

  public carinho(string i,int qtd,int cod,double p){
    itens = i;
    qtditens = qtd;
    codigo = cod;
    preco = p;
  }
  public string Getcltdono() {
    return cltdono;
  }
  public string Getitens() {
    return itens;
  }
  public int Getqtditens() {
    return qtditens;
  }
  public int Gettotal() {
    return total;
  }
  public int Getcodigo() {
    return codigo;
  }
  public double Getpreco() {
    return preco;
  }

  
}