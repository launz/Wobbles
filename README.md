# wobbles
Unity tool for general purpose spring-like animations.

## Description:

Wobbles is a simple multi purpose tool for animating and moving things in a spring-like behavior.
This version was built in C# for Unity but the code can easily used in a different environment. 

## How-To:
- create a WobbleData for object that should be animated
- use Wobbles.Follow with WobbleData, another animated value and a desired time-step, to make WobbleData.value move like a spring
- adjust WobbleData's stiffness and damping parameters to find right spring properties
- also includes WobbleData 2 and 3 as well as Follow functions for 2D and 3D movement

The example script uses the fixed time-step and stiffness/ damping values of 160/ 10.

![wobbles](https://user-images.githubusercontent.com/23469925/151717319-6b3dfdb5-c99d-47ab-9a30-0f4903da52dd.gif)
