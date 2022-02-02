# 〰️ Wobbles
Unity tool for general purpose spring-like animations.

## 🗒️ Description:

Wobbles is a simple multi purpose tool for animating and moving things in a spring-like behavior.
This version was built in C# for Unity but the code can easily used in a different environment. 

## 🛠️ Setup:

Just add Wobbles folder to Unity project. Only content of Scripts folder is needed, the rest is this readme and the example content.

## 💡 How-To:
- create WobbleData for object that should be animated
- use Wobbles.Follow with WobbleData, another animated value and a desired time-step, to make WobbleData.value move like a spring
- adjust WobbleData's stiffness and damping parameters to find right spring properties
- also includes WobbleData 2 and 3 as well as Follow functions for 2D and 3D movement

This example gif uses the fixed time-step and stiffness/ damping values of 160/ 10:


![wobbles](https://user-images.githubusercontent.com/23469925/152225186-4b1bf479-f66f-4601-a85d-7c9d109fc5ea.gif)
