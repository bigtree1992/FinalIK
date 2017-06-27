using UnityEngine;
using System.Collections;

namespace RootMotion.FinalIK {

	/// <summary>
	/// Forward and Backward Reaching %IK solver component.
	/// </summary>
	[HelpURL("http://www.root-motion.com/finalikdox/html/page4.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/FABRIK")]
	public class FABRIK : IK {

		/// <summary>
		/// The %FABRIK solver.
		/// </summary>
		public IKSolverFABRIK solver = new IKSolverFABRIK();
		
		public override IKSolver GetIKSolver() {
			return solver as IKSolver;
		}
	}
}

