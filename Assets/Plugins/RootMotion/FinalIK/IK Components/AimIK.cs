using UnityEngine;
using System.Collections;

namespace RootMotion.FinalIK {

	/// <summary>
	/// Aim %IK solver component.
	/// </summary>
	[HelpURL("https://www.youtube.com/watch?v=wT8fViZpLmQ&index=3&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Aim IK")]
	public class AimIK : IK {
		
		/// <summary>
		/// The Aim %IK solver.
		/// </summary>
		public IKSolverAim solver = new IKSolverAim();
		
		public override IKSolver GetIKSolver() {
			return solver as IKSolver;
		}
	}
}

