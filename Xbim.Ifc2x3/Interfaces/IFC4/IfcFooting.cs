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
namespace Xbim.Ifc2x3.StructuralElementsDomain
{
	public partial class @IfcFooting : IIfcFooting
	{
		Ifc4.Interfaces.IfcFootingTypeEnum? IIfcFooting.PredefinedType 
		{ 
			get
			{
				switch (PredefinedType)
				{
					case IfcFootingTypeEnum.FOOTING_BEAM:
						return Ifc4.Interfaces.IfcFootingTypeEnum.FOOTING_BEAM;
					
					case IfcFootingTypeEnum.PAD_FOOTING:
						return Ifc4.Interfaces.IfcFootingTypeEnum.PAD_FOOTING;
					
					case IfcFootingTypeEnum.PILE_CAP:
						return Ifc4.Interfaces.IfcFootingTypeEnum.PILE_CAP;
					
					case IfcFootingTypeEnum.STRIP_FOOTING:
						return Ifc4.Interfaces.IfcFootingTypeEnum.STRIP_FOOTING;
					
					case IfcFootingTypeEnum.USERDEFINED:
						return Ifc4.Interfaces.IfcFootingTypeEnum.USERDEFINED;
					
					case IfcFootingTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcFootingTypeEnum.NOTDEFINED;
					
					
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