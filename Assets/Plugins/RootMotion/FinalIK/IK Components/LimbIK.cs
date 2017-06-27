using UnityEngine;
using System.Collections;

namespace RootMotion.FinalIK {

	/// <summary>
	/// %IK component for IKSolverLimb.
	/// </summary>
	[HelpURL("http://www.root-motion.com/finalikdox/html/page7.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Limb IK")]
	public class LimbIK : IK {

		/// <summary>
		/// The Limb %IK solver.
		/// </summary>
		public IKSolverLimb solver = new IKSolverLimb();
		
		public override IKSolver GetIKSolver() {
			return solver as IKSolver;
		}
	}
}
