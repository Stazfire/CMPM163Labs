uniform sampler2D texture1;
varying vec2 vUv;
float tileSize = 5.0;

void main() {
	vec2 temp = vec2 ( (vUv.x * tileSize)- floor(vUv.x*tileSize) , (vUv.y*tileSize)-floor(vUv.y*tileSize));
	gl_FragColor = texture2D(texture1, temp);
}
