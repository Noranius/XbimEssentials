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
namespace Xbim.Ifc2x3.SharedBldgElements
{
	public partial class @IfcStairFlightType : IIfcStairFlightType
	{
		Ifc4.Interfaces.IfcStairFlightTypeEnum IIfcStairFlightType.PredefinedType 
		{ 
			get
			{
				switch (PredefinedType)
				{
					case IfcStairFlightTypeEnum.STRAIGHT:
						return Ifc4.Interfaces.IfcStairFlightTypeEnum.STRAIGHT;
					
					case IfcStairFlightTypeEnum.WINDER:
						return Ifc4.Interfaces.IfcStairFlightTypeEnum.WINDER;
					
					case IfcStairFlightTypeEnum.SPIRAL:
						return Ifc4.Interfaces.IfcStairFlightTypeEnum.SPIRAL;
					
					case IfcStairFlightTypeEnum.CURVED:
						return Ifc4.Interfaces.IfcStairFlightTypeEnum.CURVED;
					
					case IfcStairFlightTypeEnum.FREEFORM:
						return Ifc4.Interfaces.IfcStairFlightTypeEnum.FREEFORM;
					
					case IfcStairFlightTypeEnum.USERDEFINED:
						return Ifc4.Interfaces.IfcStairFlightTypeEnum.USERDEFINED;
					
					case IfcStairFlightTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcStairFlightTypeEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				
			}
		}
	//## Custom code
	//##
	}
}