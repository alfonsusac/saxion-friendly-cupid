﻿using System;
namespace GXPEngine
{
	public class Aim : Sprite
	{
		public static float targetAngle;


		public Aim() : base ("Cupid2.png")
		{
			SetOrigin(width / 2, 0); 
			SetScaleXY(0.25f, 0.25f);
		}

		void Update()
        {
			aiming();
        }

		void aiming()
        {
			Vec2 deltaVec = new Vec2(Input.mouseX - Ball.position.x, Input.mouseY - Ball.position.y);
			targetAngle = deltaVec.GetAngleDegrees() - 90  ; //jaki jest kąt
			rotation = targetAngle; //celowanie do myszki
        }

	}
}

