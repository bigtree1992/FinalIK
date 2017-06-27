using UnityEngine;
using System.Collections;

namespace RootMotion.FinalIK {

	/// <summary>
	/// %IK system for multiple branched %FABRIK chains.
	/// </summary>
	[HelpURL("http://www.root-motion.com/finalikdox/html/page5.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/FABRIK Root")]
	public class FABRIKRoot : IK {
	
		/// <summary>
		/// The %FABRIKRoot solver.
		/// </summary>
		public IKSolverFABRIKRoot solver = new IKSolverFABRIKRoot();
		
		public override IKSolver GetIKSolver() {
			return solver as IKSolver;
		}
	}
}
