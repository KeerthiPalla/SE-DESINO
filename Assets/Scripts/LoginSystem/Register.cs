using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.IO;
using System.Text.RegularExpressions;
public class Register : MonoBehaviour {
	public GameObject username;
	public GameObject password;
	public GameObject passwordConformation;
	public Text dynamicText;
	private string Name;
	private string Password;
	private string PasswordConformation;
	private string DynamicText;
	private string Form;
	void Start(){
		//username.transform.GetChild(2).GetComponent<CanvasRenderer>().SetAlpha(0f);
		Debug.LogWarning ("started Register");
		//password.transform.GetChild(2).GetComponent<CanvasRenderer>().SetAlpha(0f);
	}



	public void RegisterButton(){
		bool N = false;
		bool P = false;
		bool PC = false;

		   if (!Directory.Exists (@"E:\SEDesinoUserData")) {
			Directory.CreateDirectory(@"E:\SEDesinoUserData");
		}
		if (Name != "") {
			if (!System.IO.File.Exists (@"E:\SEDesinoUserData\" + Name + ".txt")) {
				N = true;
				Debug.LogWarning("Username Available");

				//username.transform.GetChild (3).GetComponent<CanvasRenderer> ().SetColor (Color.green);
				//username.transform.GetChild (3).GetComponent<CanvasRenderer> ().SetAlpha (0.7f);
			} else {
				//username.transform.GetChild (3).GetComponent<CanvasRenderer> ().SetColor (Color.red);
				//username.transform.GetChild (3).GetComponent<CanvasRenderer> ().SetAlpha (0.7f);
				Debug.LogWarning ("Username Has Been Taken");
				dynamicText.text = "User Already Exists";

			}
		} else {
			//username.transform.GetChild (3).GetComponent<CanvasRenderer> ().SetColor (Color.red);
			//username.transform.GetChild (3).GetComponent<CanvasRenderer> ().SetAlpha (0.7f);
			Debug.LogWarning ("Username Field is empty");
			dynamicText.text = "Username is Empty";
		}
		
		
		if (Password != ""){
			if (Password.Length > 5){
				P = true;
			} else {
				//password.transform.GetChild(3).GetComponent<CanvasRenderer>().SetColor(Color.red);
				//password.transform.GetChild(3).GetComponent<CanvasRenderer>().SetAlpha(0.7f);
				Debug.LogWarning("Password Must at least be 6 characters long");
				dynamicText.text = "password is short";
			}
		} else {
			//password.transform.GetChild(3).GetComponent<CanvasRenderer>().SetColor(Color.red);
			//password.transform.GetChild(3).GetComponent<CanvasRenderer>().SetAlpha(0.7f);
			Debug.LogWarning("Password Field is empty");
			dynamicText.text = "Password Field is empty";
		}
		if (Password == PasswordConformation){
			PC = true;
			if (P == true){
				//password.transform.GetChild(3).GetComponent<CanvasRenderer>().SetColor(Color.green);
				//password.transform.GetChild(3).GetComponent<CanvasRenderer>().SetAlpha(0.7f);
			}
		} else {
			//password.transform.GetChild(3).GetComponent<CanvasRenderer>().SetColor(Color.red);
			//password.transform.GetChild(3).GetComponent<CanvasRenderer>().SetAlpha(0.7f);
			Debug.LogWarning("Passwords Don't Match");
			dynamicText.text = "Passwords Don't Match";
		}
		if (N == true && P == true && PC == true){
			int i = 1;
			bool Clear = true;
			foreach(char c in Password){
				i++;
				if (Clear){
					Password = "";
					Clear = false;
				}
				char Encrypted = (char)(c * i);
				Password += Encrypted.ToString();
			}
			
			Form = (Name+Environment.NewLine+Password);
			System.IO.File.WriteAllText(@"E:\SEDesinoUserData\" + Name + ".txt", Form);
			print ("Registration Successful");
			dynamicText.text = "Registration Successful";
			username.GetComponent<InputField>().text = "";
			
			password.GetComponent<InputField>().text = "";
			passwordConformation.GetComponent<InputField>().text = "";

		}



}
	
	void Update () {


		if (Input.GetKeyDown(KeyCode.Tab)){
			if (username.GetComponent<InputField>().isFocused){
				password.GetComponent<InputField>().Select();
			}
			if (password.GetComponent<InputField>().isFocused){
				passwordConformation.GetComponent<InputField>().Select();
			}
			
		}
		if (Input.GetKeyDown(KeyCode.Return)){
			if (PasswordConformation != ""&&Password != ""&&Name != ""){
				RegisterButton();
			}
		}
		Name = username.GetComponent<InputField>().text;
	
		Password = password.GetComponent<InputField>().text;
		PasswordConformation = passwordConformation.GetComponent<InputField>().text;

		//dynamicText.text = "";
		
	}
}