# Rendering
Rendering has two parts
1. Rendering Pipeline runs on CPU
2. Actual Rendering runs on GPU

Unity directly controls the pipeline and uses graphics APIs to send rendering requests to GPU

## Rendering Pipeline
The Rendering Pipeline in Unity is a nightmare. 

Unity has two types of rendering pipeline:
1. Built-in Rendering Pipeline (BRP)
2. Scriptable Rendering Pipeline (SRP)

To show the capability of SRP, Unity provides two samples:
1. Universal Rendering Pipeline (URP)
2. High-Definition Rendering Pipeline (HDRP)

HDRP focus on PC. Hence, unless you are doing PC-VR (Streaming), it has nothing to do with XR dev. 

URP is almost the go-to option. 

Ordinary dev usually don't play with the SRP (or modify either URP or HDRP), although that is the purpose of the existance of these samples. 

[To learn more](https://catlikecoding.com/unity/tutorials/custom-srp/)

## Graphics APIs
There are many specifications of Graphics APIs.

For most of the XR dev, Vulkan and OpenGL ES are the most important ones. (Unless you are doing PC-VR, then DirectX may be important)

Both OpenGL ES and Vulkan were branched out from [OpenGL](https://www.khronos.org/files/opengl45-quick-reference-card.pdf).
- [OpenGL ES](https://www.khronos.org/files/opengles32-quick-reference-card.pdf) is the easy one, so start with it if you want to dig in
- [Vulkan](https://www.khronos.org/files/vulkan11-reference-guide.pdf) is the one which promises to give dev more control and better performance. However, the turth is that most of dev don't have the ability to tune it to even perform equally well as OpenGL ES

## Shader
Since rendering is running on GPU, dev normally cannot fully control the steps.

There is a way to intervene the process via **Shaders**. There are many intermittent steps and different types of shaders you can write, but the most important ones (also, which matters in Unity) are 
1. Vertex Shader (iterate each vertex)
2. Fragment Shader (iterate each fragment, or in the most of time, pixel)

Also, there are many different shader languages. In Unity, we care about CG, HLSL, GLSL. (**Use HLSL!**)

The outline of the shader file uses **ShaderLab** (a special syntax for Unity). The shader program (Your HLSL codes) goes into the ShaderLab.

For SRP, Unity also supports **Shader Graph** - A visual way of creating shader. However, Shader Graph and ShaderLab are not compatible. URP Shader Graph and HDRP Shader Graph are not compatible as well. (Annoy!!)
