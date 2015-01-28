var devices : WebCamDevice[];

function Start () {
	devices = WebCamTexture.devices;
	for( var i = 0 ; i < devices.length ; i++ ) {
		Debug.Log(devices[i].name);
	}
		
}