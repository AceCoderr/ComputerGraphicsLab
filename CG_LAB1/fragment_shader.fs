#version 330 core

in vec3 FragPos;
in vec3 Normal;
in vec2 TexCoord;

out vec4 FragColor;

uniform vec3 objectColor;
uniform vec3 lightColor;

void main() {
    vec3 ambient = 0.1 * objectColor;
    vec3 lightDir = normalize(vec3(1.0, 1.0, 1.0)); // Example directional light direction
    float diff = max(dot(Normal, lightDir), 0.0);
    vec3 diffuse = diff * lightColor;
    
    vec3 color = (ambient + diffuse) * texture(someTexture, TexCoord).xyz; // You need to load a texture and bind it

    FragColor = vec4(color, 1.0);
}
