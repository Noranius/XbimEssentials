using System;
using log4net;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using Xbim.Common.Enumerations;
using Xbim.Common.ExpressValidation;
using Xbim.Ifc4.Interfaces;
using static Xbim.Ifc4.Functions;
// ReSharper disable once CheckNamespace
// ReSharper disable InconsistentNaming
namespace Xbim.Ifc4.GeometryResource
{
	public partial class IfcReparametrisedCompositeCurveSegment : IExpressValidatable
	{
		private static readonly ILog Log = LogManager.GetLogger("Xbim.Ifc4.GeometryResource.IfcReparametrisedCompositeCurveSegment");

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(Where.IfcReparametrisedCompositeCurveSegment clause) {
			var retVal = false;
			if (clause == Where.IfcReparametrisedCompositeCurveSegment.PositiveLengthParameter) {
				try {
					retVal = ParamLength > 0;
				} catch (Exception ex) {
					Log.Error($"Exception thrown evaluating where-clause 'IfcReparametrisedCompositeCurveSegment.PositiveLengthParameter' for #{EntityLabel}.", ex);
				}
				return retVal;
			}
			return base.ValidateClause((Where.IfcCompositeCurveSegment)clause);
		}

		public new IEnumerable<ValidationResult> Validate()
		{
			foreach (var value in base.Validate())
			{
				yield return value;
			}
			if (!ValidateClause(Where.IfcReparametrisedCompositeCurveSegment.PositiveLengthParameter))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcReparametrisedCompositeCurveSegment.PositiveLengthParameter", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
// ReSharper disable once CheckNamespace
// ReSharper disable InconsistentNaming
namespace Xbim.Ifc4.Where
{
	public class IfcReparametrisedCompositeCurveSegment : IfcCompositeCurveSegment
	{
		public static readonly IfcReparametrisedCompositeCurveSegment PositiveLengthParameter = new IfcReparametrisedCompositeCurveSegment();
		protected IfcReparametrisedCompositeCurveSegment() {}
	}
}