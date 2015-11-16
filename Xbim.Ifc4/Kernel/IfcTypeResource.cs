// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.Kernel;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcTypeResource
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcTypeResource : IIfcTypeObject, IfcResourceSelect
	{
		IfcIdentifier? @Identification { get; }
		IfcText? @LongDescription { get; }
		IfcLabel? @ResourceType { get; }
		IEnumerable<IIfcRelAssignsToResource> @ResourceOf {  get; }
	
	}
}

namespace Xbim.Ifc4.Kernel
{
	[ExpressType("IfcTypeResource", 1128)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcTypeResource : IfcTypeObject, IIfcTypeResource, IEqualityComparer<@IfcTypeResource>, IEquatable<@IfcTypeResource>
	{
		#region IIfcTypeResource explicit implementation
		IfcIdentifier? IIfcTypeResource.Identification { get { return @Identification; } }	
		IfcText? IIfcTypeResource.LongDescription { get { return @LongDescription; } }	
		IfcLabel? IIfcTypeResource.ResourceType { get { return @ResourceType; } }	
		 
		IEnumerable<IIfcRelAssignsToResource> IIfcTypeResource.ResourceOf {  get { return @ResourceOf; } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTypeResource(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcIdentifier? _identification;
		private IfcText? _longDescription;
		private IfcLabel? _resourceType;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcIdentifier? @Identification 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _identification;
				((IPersistEntity)this).Activate(false);
				return _identification;
			} 
			set
			{
				SetValue( v =>  _identification = v, _identification, value,  "Identification");
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcText? @LongDescription 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _longDescription;
				((IPersistEntity)this).Activate(false);
				return _longDescription;
			} 
			set
			{
				SetValue( v =>  _longDescription = v, _longDescription, value,  "LongDescription");
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @ResourceType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _resourceType;
				((IPersistEntity)this).Activate(false);
				return _resourceType;
			} 
			set
			{
				SetValue( v =>  _resourceType = v, _resourceType, value,  "ResourceType");
			} 
		}	
		#endregion



		#region Inverse attributes
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcRelAssignsToResource> @ResourceOf 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelAssignsToResource>(e => (e.RelatingResource as IfcTypeResource) == this);
			} 
		}
		#endregion


		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
				case 3: 
				case 4: 
				case 5: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 6: 
					_identification = value.StringVal;
					return;
				case 7: 
					_longDescription = value.StringVal;
					return;
				case 8: 
					_resourceType = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
			return "";
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcTypeResource other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcTypeResource
            var root = (@IfcTypeResource)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcTypeResource left, @IfcTypeResource right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcTypeResource left, @IfcTypeResource right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcTypeResource x, @IfcTypeResource y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcTypeResource obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}