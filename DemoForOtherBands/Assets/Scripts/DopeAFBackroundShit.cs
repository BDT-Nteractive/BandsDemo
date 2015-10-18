using UnityEngine;
using System.Collections;

public class DopeAFBackroundShit : MonoBehaviour {

		public Material[] alternateMaterial;//This is an array of textures that
											//get traded with the current texture
											//being rendered.
		private MeshRenderer renderer;
		
		public int times = 0;// times is updated by click, but resets as to keep in 
							//range of alternate Materials.

		public int click = 0;//Basically this is tick. It increases every update.
		
		void Start() {

		renderer = GetComponent<MeshRenderer> ();
			
		}
//		I'm still working on simplifying this code. The timing isn't standard because
//      its a techno/electronica song. That means the beats are all over the place.
//		I am going to work on finding an algorithm that will break this code down.
// 			 --DS
		
	void Update () {
		if(Time.time < 59.6){
		if (Time.time >= 1.5 && Time.time <= 2) {
			// Basically what I did here was switch out the texture being rendered
			//in the mesh renderer with a new color. 
			renderer.material = alternateMaterial [0];
		} else if (click >= 55 && click <= 56) {
			renderer.material = alternateMaterial [times];
		} else if (click >= 58 && click <= 59) {

			renderer.material = alternateMaterial [1];
		} else if (click >= 60 && click <= 62) {
			renderer.material = alternateMaterial [times];
		} else if (Time.time >= 9 && Time.time <= 11) {
			
			renderer.material = alternateMaterial [2];
		} else if (click >= 128 && click <= 133) {
			renderer.material = alternateMaterial [times];
		} else if (click >= 134 && click <= 138) {
			renderer.material = alternateMaterial [3];
		} else if (click >= 159 && click <= 162) {
			renderer.material = alternateMaterial [times];
		} else if (click >= 175 && click <= 182) {
			renderer.material = alternateMaterial [3];
		} else if (click >= 192 && click <= 195) {
			renderer.material = alternateMaterial [times];
		} else if (click >= 196 && click <= 199) {
			renderer.material = alternateMaterial [4];
		} else if (click >= 213 && click <= 215) {
			renderer.material = alternateMaterial [times];
		} else if (click >= 220 && click <= 222) {
			renderer.material = alternateMaterial [times];
		} else if (click >= 239 && click <= 235) {
			renderer.material = alternateMaterial [times];
		} else if (click >= 236 && click <= 240) {
			renderer.material = alternateMaterial [3];
		} else if (click >= 250 && click <= 260) {
			renderer.material = alternateMaterial [times];
		} else if (click >= 265 && click <= 267) {
			renderer.material = alternateMaterial [times];
		} else if (click >= 268 && click <= 270) {
			renderer.material = alternateMaterial [1];
		} else if (click >= 271 && click <= 280) {
			renderer.material = alternateMaterial [times];
		} else if (click >= 281 && click <= 283) {
			renderer.material = alternateMaterial [2];
		} else if (click >= 284 && click <= 287) {
			renderer.material = alternateMaterial [times];

		} else if (click >= 290 && click <= 295) {
			renderer.material = alternateMaterial [0];
		} else if (click >= 296 && click <= 300) {
			renderer.material = alternateMaterial [times];
		} else if (click >= 301 && click <= 309) {
			renderer.material = alternateMaterial [2];
		} else if (click >= 310 && click <= 315) {
			renderer.material = alternateMaterial [times];
			
		} else if (click >= 316 && click <= 320) {
			renderer.material = alternateMaterial [1];
		} else if (click >= 325 && click <= 330) {
			renderer.material = alternateMaterial [times];
		} else if (click >= 331 && click <= 335) {
			renderer.material = alternateMaterial [4];
		} else if (click >= 336 && click <= 341) {
			renderer.material = alternateMaterial [2];
		} else if (click >= 342 && click <= 347) {
			renderer.material = alternateMaterial [times];
			
		} else if (click >= 352 && click <= 357) {
			renderer.material = alternateMaterial [1];
		} else if (click >= 360 && click <= 362) {
			renderer.material = alternateMaterial [times];
		} else if (click >= 363 && click <= 367) {
			renderer.material = alternateMaterial [4];
		} else if (click > 367)
			click = 268;
	}
		else{
			if (Time.time % 2 <= 4) {	

				renderer.material = alternateMaterial [times];
				
			}
		}

		if (times == 5) {
			times = 0;
		}
		times++;
		click++;
		}


	
	}