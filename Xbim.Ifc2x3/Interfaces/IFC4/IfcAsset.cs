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
namespace Xbim.Ifc2x3.SharedFacilitiesElements
{
	public partial class @IfcAsset : IIfcAsset
	{
		Ifc4.MeasureResource.IfcIdentifier? IIfcAsset.Identification 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcIdentifier(AssetID);
			} 
			set
			{
				
			}
		}
		IIfcCostValue IIfcAsset.OriginalValue 
		{ 
			get
			{
				return OriginalValue;
			} 
			set
			{
				
			}
		}
		IIfcCostValue IIfcAsset.CurrentValue 
		{ 
			get
			{
				return CurrentValue;
			} 
			set
			{
				
			}
		}
		IIfcCostValue IIfcAsset.TotalReplacementCost 
		{ 
			get
			{
				return TotalReplacementCost;
			} 
			set
			{
				
			}
		}
		IIfcActorSelect IIfcAsset.Owner 
		{ 
			get
			{
				if (Owner == null) return null;
				var ifcorganization = Owner as ActorResource.IfcOrganization;
				if (ifcorganization != null) 
					return ifcorganization;
				var ifcperson = Owner as ActorResource.IfcPerson;
				if (ifcperson != null) 
					return ifcperson;
				var ifcpersonandorganization = Owner as ActorResource.IfcPersonAndOrganization;
				if (ifcpersonandorganization != null) 
					return ifcpersonandorganization;
				return null;
			} 
			set
			{
				
			}
		}
		IIfcActorSelect IIfcAsset.User 
		{ 
			get
			{
				if (User == null) return null;
				var ifcorganization = User as ActorResource.IfcOrganization;
				if (ifcorganization != null) 
					return ifcorganization;
				var ifcperson = User as ActorResource.IfcPerson;
				if (ifcperson != null) 
					return ifcperson;
				var ifcpersonandorganization = User as ActorResource.IfcPersonAndOrganization;
				if (ifcpersonandorganization != null) 
					return ifcpersonandorganization;
				return null;
			} 
			set
			{
				
			}
		}
		IIfcPerson IIfcAsset.ResponsiblePerson 
		{ 
			get
			{
				return ResponsiblePerson;
			} 
			set
			{
				
			}
		}
		Ifc4.DateTimeResource.IfcDate? IIfcAsset.IncorporationDate 
		{ 
			get
			{
				//## Handle return of IncorporationDate for which no match was found
			    return IncorporationDate != null
			        ? new Ifc4.DateTimeResource.IfcDate(IncorporationDate.ToISODateTimeString())
			        : null;
			    //##
			} 
			set
			{
				
			}
		}
		IIfcCostValue IIfcAsset.DepreciatedValue 
		{ 
			get
			{
				return DepreciatedValue;
			} 
			set
			{
				
			}
		}
	//## Custom code
	//##
	}
}