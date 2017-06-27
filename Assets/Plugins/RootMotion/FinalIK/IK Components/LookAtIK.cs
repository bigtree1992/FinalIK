using UnityEngine;
using System.Collections;

namespace RootMotion.FinalIK {

	/// <summary>
	/// Rotates a hierarchy of bones to face a target
	/// </summary>
	[HelpURL("http://www.root-motion.com/finalikdox/html/page8.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Look At IK")]
	public class LookAtIK : IK {

	    /// <summary>
		/// The LookAt %IK solver.
		/// </summary>
		public IKSolverLookAt solver = new IKSolverLookAt();
		
		public override IKSolver GetIKSolver() {
			return solver as IKSolver;
		}
	}
}
