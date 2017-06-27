using UnityEngine;
using System.Collections;

namespace RootMotion.FinalIK {

	/// <summary>
	/// Analytic %IK algorithm based on the law of cosines
	/// </summary>
	[HelpURL("http://www.root-motion.com/finalikdox/html/page9.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Trigonometric IK")]
	public class TrigonometricIK : IK {

		/// <summary>
		/// The Trigonometric %IK solver.
		/// </summary>
		public IKSolverTrigonometric solver = new IKSolverTrigonometric();
		
		public override IKSolver GetIKSolver() {
			return solver as IKSolver;
		}
	}
}
