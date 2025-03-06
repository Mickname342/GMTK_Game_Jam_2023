# You Are The Hole: A GMTK Game Jam GAme
 ![Title_Screen](https://github.com/Mickname342/GMTK_Game_Jam_2023/blob/main/Images/Title_Screen.PNG)

 You Are The Hole is golf videogame in which you control the hole instead of the ball and have to clear the path for the ball for it to get a hole in one. It was created for the GMTK (Game Maker's Toolkit) Game Jam 2023 in 2 days

## Basic mechaincs
You will have to pull on the hole to add force to it and then launch it. The force is based on the distance of the mouse from the hole. For more information check the [Hole_Move script](https://github.com/Mickname342/GMTK_Game_Jam_2023/blob/main/GMTK_Game_Jam_2023/Assets/Scripts/Hole_Move.cs)

![Pull_Hole](https://github.com/Mickname342/GMTK_Game_Jam_2023/blob/main/Images/Drag%20Hole.PNG)

You will then have to remove obstacles for the ball by touching them with the hole. The wa it is detected is via an OnTriggerEnter2D function. For more information check the [Hole_Detection script](https://github.com/Mickname342/GMTK_Game_Jam_2023/blob/main/GMTK_Game_Jam_2023/Assets/Scripts/Hole_Detction.cs)

![Remove_Obstacles](https://github.com/Mickname342/GMTK_Game_Jam_2023/blob/main/Images/Tutorial%201.PNG)

Once the hole is back in th lagpole and the number of shots left is 0 the ball will shoot by following a set path . If it hits the hole, it will play an animation with an animation event that will switch the scene to the next level. For more information check the [Ball_Shoot script](https://github.com/Mickname342/GMTK_Game_Jam_2023/blob/main/GMTK_Game_Jam_2023/Assets/Scripts/Ball_Shoot.cs) and the [Load_Next_Level script](https://github.com/Mickname342/GMTK_Game_Jam_2023/blob/main/GMTK_Game_Jam_2023/Assets/Scripts/Load_Next_Level.cs)

##Obstacles

