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
namespace Xbim.Ifc2x3.HVACDomain
{
	public partial class @IfcTankType : IIfcTankType
	{
		Ifc4.Interfaces.IfcTankTypeEnum IIfcTankType.PredefinedType 
		{ 
			get
			{
				switch (PredefinedType)
				{
					case IfcTankTypeEnum.PREFORMED:
						//## Handle translation of PREFORMED member from IfcTankTypeEnum in property PredefinedType
                        return Ifc4.Interfaces.IfcTankTypeEnum.USERDEFINED;
						//##
										
					case IfcTankTypeEnum.SECTIONAL:
						//## Handle translation of SECTIONAL member from IfcTankTypeEnum in property PredefinedType
                        return Ifc4.Interfaces.IfcTankTypeEnum.USERDEFINED;
						//##
										
					case IfcTankTypeEnum.EXPANSION:
						return Ifc4.Interfaces.IfcTankTypeEnum.EXPANSION;
					
					case IfcTankTypeEnum.PRESSUREVESSEL:
						return Ifc4.Interfaces.IfcTankTypeEnum.PRESSUREVESSEL;
					
					case IfcTankTypeEnum.USERDEFINED:
						return Ifc4.Interfaces.IfcTankTypeEnum.USERDEFINED;
					
					case IfcTankTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcTankTypeEnum.NOTDEFINED;
					
					
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