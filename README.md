# Event and rectilinear movement
## 1. Implement UI that let configure speed, collected objects and deduct life
<img width="478" alt="image" src="https://github.com/antoniocxv/eventmovement/assets/6523949/432a754f-b84a-4169-90b8-2d3e679af1f5">
<img width="480" alt="image" src="https://github.com/antoniocxv/eventmovement/assets/6523949/882d789e-5bfb-4625-94fc-eea03ad59625">

In these two pictures we can see the UI where we can find our health that is going to be changed is we touch one red square (20 points), the score, each coin has a 100 points value and a button that is going to change, if we are in turbo mode(speed 600), the button is blue color and the text of the button "normal" to go to normal mode, and blank and turbo when we are in normal mode.

We have created several coins with a collider event that destroy our coin if the player (tag player) is the responsable and a parameter we have created in the canvas will be refreshing the Score

## 2. Collectible item who make other items move when the player is near

To solve this issue, I have decided this method: 
- The player has a parameter called "strength" (boolean) with is inactive at first.
- A item called powerup (pink cilinder) who changes the parameter "strength" to true.
- The obstacles (green spheres) will react if our player (blue cube, tagged "player") is near (100.0f) and it will move in a perpendicular direction (with y=0 not to get flying)
<img width="auto" alt="image" src="https://github.com/antoniocxv/eventmovement/assets/6523949/2279f820-194e-4fc3-863a-6181a8f3775e">

This is the code of the obstacles

## 3. Add another object that teleports you to another place in the scene

Just putting a trigger in the collider of the teleporter (white capsules) that activate a simple method which teleport the player to the other teleport. We only need to be careful assigning the right destiny in the script
<img width="auto" alt="image" src="https://github.com/antoniocxv/eventmovement/assets/6523949/ee1cb86d-f7ca-4416-b6e3-0c2b14b1b9ae">

## 4. Move an item to other one when clicking an UI button

This problem has been resolved with just a new sphere called follower, which has an script that move the player to the destiny object in the update method, and another method that is called by the button to activate the movement
<img width="auto" alt="image" src="https://github.com/antoniocxv/eventmovement/assets/6523949/82419a35-3035-4c76-a8c3-0b8cc29b1d15">

## 5. New player who follows the movement of another player when it is in the limit of the scene

I have created 4 walls. If our player touchs one of them, the follower (blue sphere) will active and goes on it. To make it, in the wall i have a trigger which change a boolean property of the follower and it starts moving.
<img width="442" alt="image" src="https://github.com/antoniocxv/eventmovement/assets/6523949/f4f38fe8-77b3-4c42-9092-c42cbc2f1585">


