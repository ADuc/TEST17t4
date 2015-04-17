using UnityEngine;
using System.Collections;

public class Mainlogin : MonoBehaviour {
	#region variables

	//Statice Variables
	public static string Email = "";
	public static string Passwork = "";

	//Public variables
	public string CurrentMenu = "Login";

	//Privite Variables
	private string CreateAccountUrl = "";
	private string LoginUrl = "";
	private string CEmail = "";
	private string CPasswork = "" ;
	private string ConfirmEmail = "";
	private string ConfirmPass = "";
	//GUI test

	public float x;
	public float y;
	public float height;
	public float width;

	#endregion

	// Use this for initialization
	void Start () {
	
	}
	// End Start menthod

	//Main GUI function 
	void OnGUI()
	{
		if (CurrentMenu == "Login") {
			LoginGUI ();
		} else if (CurrentMenu == "Create Account"){ 
			CreateAccountGUI();}
	}// End onGUI

	#region Custom Menthod
	// this menthod login account
	void LoginGUI ()
	{
		GUI.Box (new Rect (100, 100, (Screen.height/4)+ 200, (Screen.width /4)+200), " Login ");
		if (GUI.Button (new Rect (150, 350, 100, 30), "Create Account")) {
			CurrentMenu = "Create Account";
		};
		if (GUI.Button (new Rect (280,350,100, 30), "Login")){
		};
		GUI.Label (new  Rect (150, 130, 150, 30), "Email");
		Email = GUI.TextField (new Rect (150, 150, 200, 30), Email);
		GUI.Label (new  Rect (150, 180, 150, 30), "Passwork");
		Passwork = GUI.TextField (new Rect (150, 200, 200, 30), Passwork);


	}
	// This menthoid will be the GUI for Creating the account
	void CreateAccountGUI()
	{
		GUI.Box (new Rect (100, 100, (Screen.height/4)+ 200, (Screen.width /4)+200), "Create Account");

		GUI.Label (new  Rect (150, 130, 150, 30), "Email");
		CEmail = GUI.TextField (new Rect (150, 150, 200, 30), CEmail);
		GUI.Label (new  Rect (150, 180, 150, 30), "Passwork");
		CPasswork = GUI.TextField (new Rect (150, 200, 200, 30), CPasswork);
		GUI.Label (new  Rect (150, 230, 150, 30), "Confirm Email");
		ConfirmEmail = GUI.TextField (new Rect (150, 250, 200, 30),ConfirmEmail );
		GUI.Label (new  Rect (150, 280, 150, 30), "Confirm Passwork");
		ConfirmPass = GUI.TextField (new Rect (150, 300, 200, 30), ConfirmPass);

		if (GUI.Button (new Rect (150, 380, 100, 30), "Create Account")) {
			if (ConfirmEmail== CEmail && ConfirmPass == CPasswork){
			}else{}
		};
		if (GUI.Button (new Rect (280,380,100, 30), "Back")){
			CurrentMenu = "Login";
		};
	}

	#endregion
	/*#region CallCorountine
	IEnumerable CreateAccount(){
		WWWForm form* new WWWForm();
		form.AddField("Email", CEmail);
		form.AddField("Passwork", CPasswork);
		WWW CreateAccountwww = new WWW(CreateAccountUrl,Form);
		yield return CreateAccountwww;
		if (CreateAccountwww.error = null ){
			Debug.LogError("Cannot connect to Account Creation");
		}else {
			string CreateAccountReturn = CreateAccountwww.Text;
			if(CreateAccountReturn="Success");
			Debug.Log ("Sussess Account created");
			CurrentMenu = "Login";
		}

	#Endregion */
} // End Class


	