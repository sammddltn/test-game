# Super Cubicle Adventure

# using Unity version 2019.2.0f1

possible issues:

1. Maybe make a dotted line from the cursor to the player so making shots is easier?

2. The raycast currently collides with an invisible plane synched to the y axis of the player, so that we have controls working even if the camera angle changed. Unfortunately, only way I could get this working was by setting the layer for the player to "playerLayer". Every object with a RigidBody will ALSO have to be set to "playerLayer" or there will be issues. Yes, this is a fucking hassle :(
