// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Kernel;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.RepresentationResource;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcProductDefinitionShape
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcProductDefinitionShape : IIfcProductRepresentation, IfcProductRepresentationSelect
	{
		IEnumerable<IIfcProduct> @ShapeOfProduct {  get; }
		IEnumerable<IIfcShapeAspect> @HasShapeAspects {  get; }
	
	}
}

namespace Xbim.Ifc4.RepresentationResource
{
	[IndexedClass]
	[ExpressType("IfcProductDefinitionShape", 847)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcProductDefinitionShape : IfcProductRepresentation, IInstantiableEntity, IIfcProductDefinitionShape, IEqualityComparer<@IfcProductDefinitionShape>, IEquatable<@IfcProductDefinitionShape>
	{
		#region IIfcProductDefinitionShape explicit implementation
		 
		IEnumerable<IIfcProduct> IIfcProductDefinitionShape.ShapeOfProduct {  get { return @ShapeOfProduct; } }
		IEnumerable<IIfcShapeAspect> IIfcProductDefinitionShape.HasShapeAspects {  get { return @HasShapeAspects; } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcProductDefinitionShape(IModel model) : base(model) 		{ 
			Model = model; 
		}




		#region Inverse attributes
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcProduct> @ShapeOfProduct 
		{ 
			get 
			{
				return Model.Instances.Where<IfcProduct>(e => (e.Representation as IfcProductDefinitionShape) == this);
			} 
		}
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcShapeAspect> @HasShapeAspects 
		{ 
			get 
			{
				return Model.Instances.Where<IfcShapeAspect>(e => (e.PartOfProductDefinitionShape as IfcProductDefinitionShape) == this);
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*OnlyShapeModel:)) = 0;*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcProductDefinitionShape other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcProductDefinitionShape
            var root = (@IfcProductDefinitionShape)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcProductDefinitionShape left, @IfcProductDefinitionShape right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcProductDefinitionShape left, @IfcProductDefinitionShape right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcProductDefinitionShape x, @IfcProductDefinitionShape y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcProductDefinitionShape obj)
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