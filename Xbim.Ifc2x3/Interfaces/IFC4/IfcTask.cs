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
namespace Xbim.Ifc2x3.ProcessExtension
{
	public partial class @IfcTask : IIfcTask
	{
		Ifc4.MeasureResource.IfcLabel? IIfcTask.Status 
		{ 
			get
			{
				if (!Status.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(Status.Value);
			} 
		}
		Ifc4.MeasureResource.IfcLabel? IIfcTask.WorkMethod 
		{ 
			get
			{
				if (!WorkMethod.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(WorkMethod.Value);
			} 
		}
		Ifc4.MeasureResource.IfcBoolean IIfcTask.IsMilestone 
		{ 
			get
			{
				//## Handle return of IsMilestone for which no match was found
                return new Ifc4.MeasureResource.IfcBoolean(IsMilestone);
				//##
			} 
		}
		Ifc4.MeasureResource.IfcInteger? IIfcTask.Priority 
		{ 
			get
			{
				//## Handle return of Priority for which no match was found
                return Priority.HasValue ? new Ifc4.MeasureResource.IfcInteger(Priority.Value) : (Ifc4.MeasureResource.IfcInteger?)null;
				//##
			} 
		}
		IIfcTaskTime IIfcTask.TaskTime 
		{ 
			get
			{
				//## Handle return of TaskTime for which no match was found
                return null;
				//##
			} 
		}
		Ifc4.Interfaces.IfcTaskTypeEnum? IIfcTask.PredefinedType 
		{ 
			get
			{
				//## Handle return of PredefinedType for which no match was found
				return null;
				//##
			} 
		}
	//## Custom code
	//##
	}
}