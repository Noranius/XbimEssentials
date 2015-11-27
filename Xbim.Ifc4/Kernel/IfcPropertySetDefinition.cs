// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

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
    /// Readonly interface for IfcPropertySetDefinition
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcPropertySetDefinition : IIfcPropertyDefinition, IfcPropertySetDefinitionSelect
	{
		IEnumerable<IIfcTypeObject> @DefinesType {  get; }
		IEnumerable<IIfcRelDefinesByTemplate> @IsDefinedBy {  get; }
		IEnumerable<IIfcRelDefinesByProperties> @DefinesOccurrence {  get; }
	
	}
}

namespace Xbim.Ifc4.Kernel
{
	[ExpressType("IfcPropertySetDefinition", 866)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcPropertySetDefinition : IfcPropertyDefinition, IIfcPropertySetDefinition, IEqualityComparer<@IfcPropertySetDefinition>, IEquatable<@IfcPropertySetDefinition>
	{
		#region IIfcPropertySetDefinition explicit implementation
		 
		IEnumerable<IIfcTypeObject> IIfcPropertySetDefinition.DefinesType {  get { return @DefinesType; } }
		IEnumerable<IIfcRelDefinesByTemplate> IIfcPropertySetDefinition.IsDefinedBy {  get { return @IsDefinedBy; } }
		IEnumerable<IIfcRelDefinesByProperties> IIfcPropertySetDefinition.DefinesOccurrence {  get { return @DefinesOccurrence; } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPropertySetDefinition(IModel model) : base(model) 		{ 
			Model = model; 
		}




		#region Inverse attributes
		[InverseProperty("HasPropertySets")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 0, -1, 7)]
		public IEnumerable<IfcTypeObject> @DefinesType 
		{ 
			get 
			{
				return Model.Instances.Where<IfcTypeObject>(e => e.HasPropertySets != null &&  e.HasPropertySets.Contains(this), "HasPropertySets", this);
			} 
		}
		[InverseProperty("RelatedPropertySets")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 0, -1, 8)]
		public IEnumerable<IfcRelDefinesByTemplate> @IsDefinedBy 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelDefinesByTemplate>(e => e.RelatedPropertySets != null &&  e.RelatedPropertySets.Contains(this), "RelatedPropertySets", this);
			} 
		}
		[InverseProperty("RelatingPropertyDefinition")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 0, -1, 9)]
		public IEnumerable<IfcRelDefinesByProperties> @DefinesOccurrence 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelDefinesByProperties>(e => (e.RelatingPropertyDefinition as IfcPropertySetDefinition) == this, "RelatingPropertyDefinition", this);
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
					base.Parse(propIndex, value, nestedIndex); 
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
        public bool Equals(@IfcPropertySetDefinition other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcPropertySetDefinition
            var root = (@IfcPropertySetDefinition)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcPropertySetDefinition left, @IfcPropertySetDefinition right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcPropertySetDefinition left, @IfcPropertySetDefinition right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcPropertySetDefinition x, @IfcPropertySetDefinition y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcPropertySetDefinition obj)
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