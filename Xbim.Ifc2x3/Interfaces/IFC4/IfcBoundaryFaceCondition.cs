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
namespace Xbim.Ifc2x3.StructuralLoadResource
{
	public partial class @IfcBoundaryFaceCondition : IIfcBoundaryFaceCondition
	{
		IIfcModulusOfSubgradeReactionSelect IIfcBoundaryFaceCondition.TranslationalStiffnessByAreaX 
		{ 
			get
			{
				//## Handle return of TranslationalStiffnessByAreaX for which no match was found
			    var value = LinearStiffnessByAreaX;
                if(!value.HasValue) return null;
                return new Ifc4.MeasureResource.IfcModulusOfSubgradeReactionMeasure(value.Value);
			    //##
			} 
			set
			{
				
			}
		}
		IIfcModulusOfSubgradeReactionSelect IIfcBoundaryFaceCondition.TranslationalStiffnessByAreaY 
		{ 
			get
			{
				//## Handle return of TranslationalStiffnessByAreaY for which no match was found
                var value = LinearStiffnessByAreaY;
                if (!value.HasValue) return null;
                return new Ifc4.MeasureResource.IfcModulusOfSubgradeReactionMeasure(value.Value);
				//##
			} 
			set
			{
				
			}
		}
		IIfcModulusOfSubgradeReactionSelect IIfcBoundaryFaceCondition.TranslationalStiffnessByAreaZ 
		{ 
			get
			{
				//## Handle return of TranslationalStiffnessByAreaZ for which no match was found
                var value = LinearStiffnessByAreaZ;
                if (!value.HasValue) return null;
                return new Ifc4.MeasureResource.IfcModulusOfSubgradeReactionMeasure(value.Value);
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