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
namespace Xbim.Ifc2x3.GeometricConstraintResource
{
	public partial class @IfcConnectionSurfaceGeometry : IIfcConnectionSurfaceGeometry
	{
		IIfcSurfaceOrFaceSurface IIfcConnectionSurfaceGeometry.SurfaceOnRelatingElement 
		{ 
			get
			{
				if (SurfaceOnRelatingElement == null) return null;
				var ifcsurface = SurfaceOnRelatingElement as GeometryResource.IfcSurface;
				if (ifcsurface != null) 
					return ifcsurface;
				var ifcfacesurface = SurfaceOnRelatingElement as TopologyResource.IfcFaceSurface;
				if (ifcfacesurface != null) 
					return ifcfacesurface;
				var ifcfacebasedsurfacemodel = SurfaceOnRelatingElement as GeometricModelResource.IfcFaceBasedSurfaceModel;
				if (ifcfacebasedsurfacemodel != null) 
					return ifcfacebasedsurfacemodel;
				return null;
			} 
			set
			{
				
			}
		}
		IIfcSurfaceOrFaceSurface IIfcConnectionSurfaceGeometry.SurfaceOnRelatedElement 
		{ 
			get
			{
				if (SurfaceOnRelatedElement == null) return null;
				var ifcsurface = SurfaceOnRelatedElement as GeometryResource.IfcSurface;
				if (ifcsurface != null) 
					return ifcsurface;
				var ifcfacesurface = SurfaceOnRelatedElement as TopologyResource.IfcFaceSurface;
				if (ifcfacesurface != null) 
					return ifcfacesurface;
				var ifcfacebasedsurfacemodel = SurfaceOnRelatedElement as GeometricModelResource.IfcFaceBasedSurfaceModel;
				if (ifcfacebasedsurfacemodel != null) 
					return ifcfacebasedsurfacemodel;
				return null;
			} 
			set
			{
				
			}
		}
	//## Custom code
	//##
	}
}