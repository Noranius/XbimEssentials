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
namespace Xbim.Ifc2x3.ElectricalDomain
{
	public partial class @IfcProtectiveDeviceType : IIfcProtectiveDeviceType
	{
		Ifc4.Interfaces.IfcProtectiveDeviceTypeEnum IIfcProtectiveDeviceType.PredefinedType 
		{ 
			get
			{
				switch (PredefinedType)
				{
					case IfcProtectiveDeviceTypeEnum.FUSEDISCONNECTOR:
						return Ifc4.Interfaces.IfcProtectiveDeviceTypeEnum.FUSEDISCONNECTOR;
					
					case IfcProtectiveDeviceTypeEnum.CIRCUITBREAKER:
						return Ifc4.Interfaces.IfcProtectiveDeviceTypeEnum.CIRCUITBREAKER;
					
					case IfcProtectiveDeviceTypeEnum.EARTHFAILUREDEVICE:
						//## Handle translation of EARTHFAILUREDEVICE member from IfcProtectiveDeviceTypeEnum in property PredefinedType
                        return Ifc4.Interfaces.IfcProtectiveDeviceTypeEnum.EARTHLEAKAGECIRCUITBREAKER;
						//##
										
					case IfcProtectiveDeviceTypeEnum.RESIDUALCURRENTCIRCUITBREAKER:
						return Ifc4.Interfaces.IfcProtectiveDeviceTypeEnum.RESIDUALCURRENTCIRCUITBREAKER;
					
					case IfcProtectiveDeviceTypeEnum.RESIDUALCURRENTSWITCH:
						return Ifc4.Interfaces.IfcProtectiveDeviceTypeEnum.RESIDUALCURRENTSWITCH;
					
					case IfcProtectiveDeviceTypeEnum.VARISTOR:
						return Ifc4.Interfaces.IfcProtectiveDeviceTypeEnum.VARISTOR;
					
					case IfcProtectiveDeviceTypeEnum.USERDEFINED:
						return Ifc4.Interfaces.IfcProtectiveDeviceTypeEnum.USERDEFINED;
					
					case IfcProtectiveDeviceTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcProtectiveDeviceTypeEnum.NOTDEFINED;
					
					
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