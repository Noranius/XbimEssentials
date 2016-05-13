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
namespace Xbim.Ifc2x3.UtilityResource
{
	public partial class @IfcOwnerHistory : IIfcOwnerHistory
	{
		IIfcPersonAndOrganization IIfcOwnerHistory.OwningUser 
		{ 
			get
			{
				return OwningUser;
			} 
			set
			{
				
			}
		}
		IIfcApplication IIfcOwnerHistory.OwningApplication 
		{ 
			get
			{
				return OwningApplication;
			} 
			set
			{
				
			}
		}
		Ifc4.Interfaces.IfcStateEnum? IIfcOwnerHistory.State 
		{ 
			get
			{
				switch (State)
				{
					case IfcStateEnum.READWRITE:
						return Ifc4.Interfaces.IfcStateEnum.READWRITE;
					
					case IfcStateEnum.READONLY:
						return Ifc4.Interfaces.IfcStateEnum.READONLY;
					
					case IfcStateEnum.LOCKED:
						return Ifc4.Interfaces.IfcStateEnum.LOCKED;
					
					case IfcStateEnum.READWRITELOCKED:
						return Ifc4.Interfaces.IfcStateEnum.READWRITELOCKED;
					
					case IfcStateEnum.READONLYLOCKED:
						return Ifc4.Interfaces.IfcStateEnum.READONLYLOCKED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				
			}
		}
		Ifc4.Interfaces.IfcChangeActionEnum? IIfcOwnerHistory.ChangeAction 
		{ 
			get
			{
				switch (ChangeAction)
				{
					case IfcChangeActionEnum.NOCHANGE:
						return Ifc4.Interfaces.IfcChangeActionEnum.NOCHANGE;
					
					case IfcChangeActionEnum.MODIFIED:
						return Ifc4.Interfaces.IfcChangeActionEnum.MODIFIED;
					
					case IfcChangeActionEnum.ADDED:
						return Ifc4.Interfaces.IfcChangeActionEnum.ADDED;
					
					case IfcChangeActionEnum.DELETED:
						return Ifc4.Interfaces.IfcChangeActionEnum.DELETED;
					
					case IfcChangeActionEnum.MODIFIEDADDED:
						//## Handle translation of MODIFIEDADDED member from IfcChangeActionEnum in property ChangeAction
                        return Ifc4.Interfaces.IfcChangeActionEnum.ADDED;
						//##
										
					case IfcChangeActionEnum.MODIFIEDDELETED:
						//## Handle translation of MODIFIEDDELETED member from IfcChangeActionEnum in property ChangeAction
                        return Ifc4.Interfaces.IfcChangeActionEnum.DELETED;
						//##
										
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				
			}
		}
		Ifc4.DateTimeResource.IfcTimeStamp? IIfcOwnerHistory.LastModifiedDate 
		{ 
			get
			{
				if (!LastModifiedDate.HasValue) return null;
				return new Ifc4.DateTimeResource.IfcTimeStamp(LastModifiedDate.Value);
			} 
			set
			{
				
			}
		}
		IIfcPersonAndOrganization IIfcOwnerHistory.LastModifyingUser 
		{ 
			get
			{
				return LastModifyingUser;
			} 
			set
			{
				
			}
		}
		IIfcApplication IIfcOwnerHistory.LastModifyingApplication 
		{ 
			get
			{
				return LastModifyingApplication;
			} 
			set
			{
				
			}
		}
		Ifc4.DateTimeResource.IfcTimeStamp IIfcOwnerHistory.CreationDate 
		{ 
			get
			{
				return new Ifc4.DateTimeResource.IfcTimeStamp(CreationDate);
			} 
			set
			{
				
			}
		}
	//## Custom code
	//##
	}
}