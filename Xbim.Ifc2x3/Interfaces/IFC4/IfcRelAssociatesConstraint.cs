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
namespace Xbim.Ifc2x3.ControlExtension
{
	public partial class @IfcRelAssociatesConstraint : IIfcRelAssociatesConstraint
	{
		Ifc4.MeasureResource.IfcLabel? IIfcRelAssociatesConstraint.Intent 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcLabel(Intent);
			} 
			set
			{
				
			}
		}
		IIfcConstraint IIfcRelAssociatesConstraint.RelatingConstraint 
		{ 
			get
			{
				return RelatingConstraint;
			} 
			set
			{
				
			}
		}
	//## Custom code
	//##
	}
}