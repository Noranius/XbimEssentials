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
namespace Xbim.Ifc2x3.PresentationAppearanceResource
{
	public partial class @IfcPixelTexture : IIfcPixelTexture
	{
		Ifc4.MeasureResource.IfcInteger IIfcPixelTexture.Width 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcInteger(Width);
			} 
			set
			{
				
			}
		}
		Ifc4.MeasureResource.IfcInteger IIfcPixelTexture.Height 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcInteger(Height);
			} 
			set
			{
				
			}
		}
		Ifc4.MeasureResource.IfcInteger IIfcPixelTexture.ColourComponents 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcInteger(ColourComponents);
			} 
			set
			{
				
			}
		}
		IEnumerable<Xbim.Ifc4.MeasureResource.IfcBinary> IIfcPixelTexture.Pixel 
		{ 
			get
			{
				//## Handle return of Pixel for which no match was found
                return Pixel.Select(p => (new Ifc4.MeasureResource.IfcBinary(p)));
			    //##
			} 
		}
	//## Custom code
	//##
	}
}