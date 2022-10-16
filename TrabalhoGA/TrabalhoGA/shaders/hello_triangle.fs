#version 460

//uniform vec4 inputColor;
out vec4 color;

in vec4 vertexColor;

uniform vec4 inputColor;

void main()
{

	color = inputColor;

}