// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using System.Collections.Generic;
using System.Linq;

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc2x3.StructuralAnalysisDomain
{
	public partial class @IfcStructuralAnalysisModel : IIfcStructuralAnalysisModel
	{
		Ifc4.Interfaces.IfcAnalysisModelTypeEnum IIfcStructuralAnalysisModel.PredefinedType 
		{ 
			get
			{
				switch (PredefinedType)
				{
					case IfcAnalysisModelTypeEnum.IN_PLANE_LOADING_2D:
						return Ifc4.Interfaces.IfcAnalysisModelTypeEnum.IN_PLANE_LOADING_2D;
					
					case IfcAnalysisModelTypeEnum.OUT_PLANE_LOADING_2D:
						return Ifc4.Interfaces.IfcAnalysisModelTypeEnum.OUT_PLANE_LOADING_2D;
					
					case IfcAnalysisModelTypeEnum.LOADING_3D:
						return Ifc4.Interfaces.IfcAnalysisModelTypeEnum.LOADING_3D;
					
					case IfcAnalysisModelTypeEnum.USERDEFINED:
						return Ifc4.Interfaces.IfcAnalysisModelTypeEnum.USERDEFINED;
					
					case IfcAnalysisModelTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcAnalysisModelTypeEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				
			}
		}
		IIfcAxis2Placement3D IIfcStructuralAnalysisModel.OrientationOf2DPlane 
		{ 
			get
			{
				return OrientationOf2DPlane;
			} 
			set
			{
				
			}
		}
		IEnumerable<IIfcStructuralLoadGroup> IIfcStructuralAnalysisModel.LoadedBy 
		{ 
			get
			{
				foreach (var member in LoadedBy)
				{
					yield return member as IIfcStructuralLoadGroup;
				}
			} 
		}
		IEnumerable<IIfcStructuralResultGroup> IIfcStructuralAnalysisModel.HasResults 
		{ 
			get
			{
				foreach (var member in HasResults)
				{
					yield return member as IIfcStructuralResultGroup;
				}
			} 
		}
		IIfcObjectPlacement IIfcStructuralAnalysisModel.SharedPlacement 
		{ 
			get
			{
				//## Handle return of SharedPlacement for which no match was found
                return null;
				//##
			} 
			set
			{
				
			}
		}
	//## Custom code
	//##
	}
}