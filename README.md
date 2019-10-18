<h3>Instalation</h3>
Download Unity Hub https://unity3d.com/get-unity/download

<h3>File structure </h3>
<h4>Unity Projects <h4>
  TODO
<h4>Non-Unity Projects </h4>
  <li>Code files (*.cs) and Form files -> ./src <li>
  <li>Text files -> ./data </li> 

<h3>Code conventions </h3>
  All that may be private SHOULD be private. <br>
  All names must be self describing
  
  <li>Functions naming:  CamelCase();</li>
  <li>Fields naming:  int lowCamelCase;</li>
  <li>Local variables: int lowCamelCase</li>
  <li>Non-code file names: separated_by_underline.txt </li>
  
  Locals may use shorters names in case of long formulas or long fields names
  
  <h4> Good names </h4>
    <li>  int Add(int left, int right) </li>
    <li> MoveProcessor() </li>
    <li> Observer moveObeserver </li>
    <li> string msg </li>
    <li>  int i //iterator</li>
    <li> int m //local variable)</li>
  <h4> Bad names </h4>
    <li> myBrandNewIntAddFunction  </li>
    <li> foo() </li>
    <li> Foo() </li>
    <li> f() </li>
    <li> private int m  //field</li>

