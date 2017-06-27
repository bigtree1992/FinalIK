using UnityEngine;
using System.Collections;

namespace RootMotion {

	/// <summary>
	/// Contains the information about which way the limbs should be bent.
	/// </summary>
	[System.Serializable]
	public class BipedLimbOrientations {

		[System.Serializable]
		public class LimbOrientation {
			public Vector3 upperBoneForwardAxis;
			public Vector3 lowerBoneForwardAxis;
			public Vector3 lastBoneLeftAxis;

			public LimbOrientation(Vector3 upperBoneForwardAxis, Vector3 lowerBoneForwardAxis, Vector3 lastBoneLeftAxis) {
				this.upperBoneForwardAxis = upperBoneForwardAxis;
				this.lowerBoneForwardAxis = lowerBoneForwardAxis;
				this.lastBoneLeftAxis = lastBoneLeftAxis;
			}
		}

		public LimbOrientation leftArm, rightArm, leftLeg, rightLeg;

		/// <summary>
		/// Initializes a new instance of the <see cref="RootMotion.FinalIK.FullBodyBipedBendDirections"/> class.
		/// </summary>
		public BipedLimbOrientations (LimbOrientation leftArm, LimbOrientation rightArm, LimbOrientation leftLeg, LimbOrientation rightLeg) {
			this.leftArm = leftArm;
			this.rightArm = rightArm;
			this.leftLeg = leftLeg;
			this.rightLeg = rightLeg;
		}

		/// <summary>
		/// Gets the local bend directions of the standard UMA skeleton.
		/// </summary>
		public static BipedLimbOrientations UMA {
			get {
				return new BipedLimbOrientations(
					new LimbOrientation(Vector3.forward, Vector3.forward, Vector3.forward), 
					new LimbOrientation(Vector3.forward, Vector3.forward, Vector3.back), 
					new LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down), 
					new LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down)
					);
			}
		}
		
		/// <summary>
		/// Gets the local bend directions of the standard 3ds Max Biped skeleton.
		/// </summary>
		public static BipedLimbOrientations MaxBiped {
			get {
				return new BipedLimbOrientations(
					new LimbOrientation(Vector3.down, Vector3.down, Vector3.down), 
					new LimbOrientation(Vector3.down, Vector3.down, Vector3.up), 
					new LimbOrientation(Vector3.up, Vector3.up, Vector3.back), 
					new LimbOrientation(Vector3.up, Vector3.up, Vector3.back)
					);
			}
		}

		
	}
}
