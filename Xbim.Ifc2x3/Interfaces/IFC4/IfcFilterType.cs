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
	public partial class @IfcFilterType : IIfcFilterType
	{
		Ifc4.Interfaces.IfcFilterTypeEnum IIfcFilterType.PredefinedType 
		{ 
			get
			{
				switch (PredefinedType)
				{
					case IfcFilterTypeEnum.AIRPARTICLEFILTER:
						return Ifc4.Interfaces.IfcFilterTypeEnum.AIRPARTICLEFILTER;
					
					case IfcFilterTypeEnum.ODORFILTER:
						return Ifc4.Interfaces.IfcFilterTypeEnum.ODORFILTER;
					
					case IfcFilterTypeEnum.OILFILTER:
						return Ifc4.Interfaces.IfcFilterTypeEnum.OILFILTER;
					
					case IfcFilterTypeEnum.STRAINER:
						return Ifc4.Interfaces.IfcFilterTypeEnum.STRAINER;
					
					case IfcFilterTypeEnum.WATERFILTER:
						return Ifc4.Interfaces.IfcFilterTypeEnum.WATERFILTER;
					
					case IfcFilterTypeEnum.USERDEFINED:
						return Ifc4.Interfaces.IfcFilterTypeEnum.USERDEFINED;
					
					case IfcFilterTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcFilterTypeEnum.NOTDEFINED;
					
					
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