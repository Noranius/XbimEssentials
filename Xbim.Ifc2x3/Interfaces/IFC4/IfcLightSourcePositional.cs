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
namespace Xbim.Ifc2x3.PresentationOrganizationResource
{
	public partial class @IfcLightSourcePositional : IIfcLightSourcePositional
	{
		IIfcCartesianPoint IIfcLightSourcePositional.Position 
		{ 
			get
			{
				return Position;
			} 
			set
			{
				
			}
		}
		Ifc4.MeasureResource.IfcPositiveLengthMeasure IIfcLightSourcePositional.Radius 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(Radius);
			} 
			set
			{
				
			}
		}
		Ifc4.MeasureResource.IfcReal IIfcLightSourcePositional.ConstantAttenuation 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcReal(ConstantAttenuation);
			} 
			set
			{
				
			}
		}
		Ifc4.MeasureResource.IfcReal IIfcLightSourcePositional.DistanceAttenuation 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcReal(DistanceAttenuation);
			} 
			set
			{
				
			}
		}
		Ifc4.MeasureResource.IfcReal IIfcLightSourcePositional.QuadricAttenuation 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcReal(QuadricAttenuation);
			} 
			set
			{
				
			}
		}
	//## Custom code
	//##
	}
}