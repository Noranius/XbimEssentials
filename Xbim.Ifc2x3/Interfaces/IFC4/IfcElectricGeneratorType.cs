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
	public partial class @IfcElectricGeneratorType : IIfcElectricGeneratorType
	{
		Ifc4.Interfaces.IfcElectricGeneratorTypeEnum IIfcElectricGeneratorType.PredefinedType 
		{ 
			get
			{
				switch (PredefinedType)
				{
					case IfcElectricGeneratorTypeEnum.USERDEFINED:
						return Ifc4.Interfaces.IfcElectricGeneratorTypeEnum.USERDEFINED;
					
					case IfcElectricGeneratorTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcElectricGeneratorTypeEnum.NOTDEFINED;
					
					
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