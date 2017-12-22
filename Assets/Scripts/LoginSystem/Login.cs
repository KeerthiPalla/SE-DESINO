using UnityEngine;
//using UnityEditor;
using System.Collections;
using UnityEngine.UI;
using System;
using System.IO;
public class Login : MonoBehaviour {
	public GameObject username;
	public GameObject password;
	public Text setText;
	private string Name;
	private string Password;
	public string[] lines;
	private string decryptedPass;

	void Start(){

		Debug.LogWarning ("started Login");
	}
	public void LoginButton(){
		bool N = false;
		bool P = false;
		if (Name != ""){
			if (System.IO.File.Exists(@"E:\SEDesinoUserData\"+Name+".txt")){
				lines = File.ReadAllLines(@"E:\SEDesinoUserData\"+Name+".txt");
				N = true;
				if (Password != ""){

						int i = 1;
						foreach(char c in lines[1]){
							i++;
							char decrypted = (char)(c / i);
							decryptedPass += decrypted.ToString();
						}
						if (Password == decryptedPass){
							P = true;
						} else {
							Debug.LogWarning("Password Field is Incorrect");
							decryptedPass = "";
						}
					 
						
					}
					else{
					Debug.LogWarning("Password is Empty");
				}
				} else {
					Debug.LogWarning("Invalid Username Or Password");
					
				}
			} else {
				Debug.LogWarning("Username is Empty");

			}
			if (N == true && P == true) {
			print ("Login Successful");
			setText.text = "Login Successful";
			setText.color= Color.green;
			username.GetComponent<InputField> ().text = "";
			password.GetComponent<InputField> ().text = "";
			PlayerPrefs.SetString("LoggedInAs",Name);

			if (!System.IO.File.Exists (@"E:\SEDesinoUserData\" +Name+ "CC.txt")){
				System.IO.File.Create (@"E:\SEDesinoUserData\" +Name+ "CC.txt").Close ();
				System.IO.File.WriteAllText(@"E:\SEDesinoUserData\"+Name+"CC.txt","0" );
			}
			if (!System.IO.File.Exists (@"E:\SEDesinoUserData\" +Name+ "DP.txt")){
				System.IO.File.Create (@"E:\SEDesinoUserData\" +Name+ "DP.txt").Close ();
				System.IO.File.WriteAllText(@"E:\SEDesinoUserData\"+Name+"DP.txt","0" );
			}
			if (!System.IO.File.Exists (@"E:\SEDesinoUserData\" +Name+ "UML.txt")){
				System.IO.File.Create (@"E:\SEDesinoUserData\" +Name+ "UML.txt").Close ();
				System.IO.File.WriteAllText(@"E:\SEDesinoUserData\"+Name+"UML.txt","0" );
			}
			if (!System.IO.File.Exists (@"E:\SEDesinoUserData\" +Name+ "Score.txt")){
				System.IO.File.Create (@"E:\SEDesinoUserData\" +Name+ "Score.txt").Close ();
				System.IO.File.WriteAllText(@"E:\SEDesinoUserData\"+Name+"Score.txt","0"+Environment.NewLine+"0"+Environment.NewLine+"0" );
			}
			
			
			if (System.IO.File.Exists (@"E:\SEDesinoUserData\CC.txt"))
				System.IO.File.Copy(@"E:\SEDesinoUserData\" +Name+ "CC.txt", @"E:\SEDesinoUserData\CC.txt",true);
			else {
				System.IO.File.Create (@"E:\SEDesinoUserData\CC.txt").Close();
				System.IO.File.Copy(@"E:\SEDesinoUserData\" +Name+ "CC.txt", @"E:\SEDesinoUserData\CC.txt",true);
			}
			if (System.IO.File.Exists (@"E:\SEDesinoUserData\DP.txt"))
				System.IO.File.Copy(@"E:\SEDesinoUserData\" +Name+ "DP.txt", @"E:\SEDesinoUserData\DP.txt",true);
			else {
				System.IO.File.Create (@"E:\SEDesinoUserData\DP.txt").Close();
				System.IO.File.Copy(@"E:\SEDesinoUserData\" +Name+ "DP.txt", @"E:\SEDesinoUserData\DP.txt",true);
			}
			if (System.IO.File.Exists (@"E:\SEDesinoUserData\UML.txt"))
				System.IO.File.Copy(@"E:\SEDesinoUserData\" +Name+ "UML.txt", @"E:\SEDesinoUserData\UML.txt",true);
			else {
				System.IO.File.Create (@"E:\SEDesinoUserData\UML.txt").Close();
				System.IO.File.Copy(@"E:\SEDesinoUserData\" +Name+ "UML.txt", @"E:\SEDesinoUserData\UML.txt",true);
			}
			if (System.IO.File.Exists (@"E:\SEDesinoUserData\Score.txt"))
				System.IO.File.Copy(@"E:\SEDesinoUserData\" +Name+ "Score.txt", @"E:\SEDesinoUserData\Score.txt",true);
			else {
				System.IO.File.Create (@"E:\SEDesinoUserData\Score.txt").Close();
				System.IO.File.Copy(@"E:\SEDesinoUserData\" +Name+ "Score.txt", @"E:\SEDesinoUserData\Score.txt",true);
			}
			Debug.LogWarning ("Files Created");
			Application.LoadLevel ("MainMenu");
		} 
		else {
			setText.text = "Invalid Username Or Password";
			setText.color=Color.red;
		}
	}
	
	void Update () {

		if (Input.GetKeyDown(KeyCode.Tab)){
			if (username.GetComponent<InputField>().isFocused){
				password.GetComponent<InputField>().Select();
			}
		}
		if (Input.GetKeyDown(KeyCode.Return)){
			if (Password != ""&&Name != ""){
				LoginButton();
			}
		}
		Name = username.GetComponent<InputField>().text;
		Password = password.GetComponent<InputField>().text;
	}
}
