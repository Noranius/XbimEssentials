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
namespace Xbim.Ifc2x3.GeometricModelResource
{
	public partial class @IfcCsgPrimitive3D : IIfcCsgPrimitive3D
	{
		IIfcAxis2Placement3D IIfcCsgPrimitive3D.Position 
		{ 
			get
			{
				return Position;
			} 
			set
			{
				
			}
		}
		Ifc4.GeometryResource.IfcDimensionCount Ifc4.GeometricModelResource.IfcBooleanOperand.Dim 
		{
			get 
			{
				return new Ifc4.GeometryResource.IfcDimensionCount(Dim);
			}
		}

	//## Custom code
	//##
	}
}