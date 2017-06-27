using UnityEngine;
using System.Collections;

namespace RootMotion.FinalIK {

	/// <summary>
	/// CCD (Cyclic Coordinate Descent) %IK solver component.
	/// </summary>
	[HelpURL("http://www.root-motion.com/finalikdox/html/page3.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/CCD IK")]
	public class CCDIK : IK {

		/// <summary>
		/// The CCD %IK solver.
		/// </summary>
		public IKSolverCCD solver = new IKSolverCCD();
		
		public override IKSolver GetIKSolver() {
			return solver as IKSolver;
		}
	}
}
