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
namespace Xbim.Ifc2x3.ProductExtension
{
	public partial class @IfcElementAssembly : IIfcElementAssembly
	{
		Ifc4.Interfaces.IfcAssemblyPlaceEnum? IIfcElementAssembly.AssemblyPlace 
		{ 
			get
			{
				switch (AssemblyPlace)
				{
					case IfcAssemblyPlaceEnum.SITE:
						return Ifc4.Interfaces.IfcAssemblyPlaceEnum.SITE;
					
					case IfcAssemblyPlaceEnum.FACTORY:
						return Ifc4.Interfaces.IfcAssemblyPlaceEnum.FACTORY;
					
					case IfcAssemblyPlaceEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcAssemblyPlaceEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				
			}
		}
		Ifc4.Interfaces.IfcElementAssemblyTypeEnum? IIfcElementAssembly.PredefinedType 
		{ 
			get
			{
				switch (PredefinedType)
				{
					case IfcElementAssemblyTypeEnum.ACCESSORY_ASSEMBLY:
						return Ifc4.Interfaces.IfcElementAssemblyTypeEnum.ACCESSORY_ASSEMBLY;
					
					case IfcElementAssemblyTypeEnum.ARCH:
						return Ifc4.Interfaces.IfcElementAssemblyTypeEnum.ARCH;
					
					case IfcElementAssemblyTypeEnum.BEAM_GRID:
						return Ifc4.Interfaces.IfcElementAssemblyTypeEnum.BEAM_GRID;
					
					case IfcElementAssemblyTypeEnum.BRACED_FRAME:
						return Ifc4.Interfaces.IfcElementAssemblyTypeEnum.BRACED_FRAME;
					
					case IfcElementAssemblyTypeEnum.GIRDER:
						return Ifc4.Interfaces.IfcElementAssemblyTypeEnum.GIRDER;
					
					case IfcElementAssemblyTypeEnum.REINFORCEMENT_UNIT:
						return Ifc4.Interfaces.IfcElementAssemblyTypeEnum.REINFORCEMENT_UNIT;
					
					case IfcElementAssemblyTypeEnum.RIGID_FRAME:
						return Ifc4.Interfaces.IfcElementAssemblyTypeEnum.RIGID_FRAME;
					
					case IfcElementAssemblyTypeEnum.SLAB_FIELD:
						return Ifc4.Interfaces.IfcElementAssemblyTypeEnum.SLAB_FIELD;
					
					case IfcElementAssemblyTypeEnum.TRUSS:
						return Ifc4.Interfaces.IfcElementAssemblyTypeEnum.TRUSS;
					
					case IfcElementAssemblyTypeEnum.USERDEFINED:
						return Ifc4.Interfaces.IfcElementAssemblyTypeEnum.USERDEFINED;
					
					case IfcElementAssemblyTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcElementAssemblyTypeEnum.NOTDEFINED;
					
					
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