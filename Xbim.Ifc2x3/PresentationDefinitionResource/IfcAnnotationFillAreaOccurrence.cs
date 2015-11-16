// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.GeometryResource;
using Xbim.Ifc2x3.RepresentationResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.PresentationDefinitionResource;

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcAnnotationFillAreaOccurrence
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcAnnotationFillAreaOccurrence : IIfcAnnotationOccurrence
	{
		IIfcPoint @FillStyleTarget { get; }
		IfcGlobalOrLocalEnum? @GlobalOrLocal { get; }
	
	}
}

namespace Xbim.Ifc2x3.PresentationDefinitionResource
{
	[ExpressType("IfcAnnotationFillAreaOccurrence", 544)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcAnnotationFillAreaOccurrence : IfcAnnotationOccurrence, IInstantiableEntity, IIfcAnnotationFillAreaOccurrence, IEqualityComparer<@IfcAnnotationFillAreaOccurrence>, IEquatable<@IfcAnnotationFillAreaOccurrence>
	{
		#region IIfcAnnotationFillAreaOccurrence explicit implementation
		IIfcPoint IIfcAnnotationFillAreaOccurrence.FillStyleTarget { get { return @FillStyleTarget; } }	
		IfcGlobalOrLocalEnum? IIfcAnnotationFillAreaOccurrence.GlobalOrLocal { get { return @GlobalOrLocal; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcAnnotationFillAreaOccurrence(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcPoint _fillStyleTarget;
		private IfcGlobalOrLocalEnum? _globalOrLocal;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcPoint @FillStyleTarget 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _fillStyleTarget;
				((IPersistEntity)this).Activate(false);
				return _fillStyleTarget;
			} 
			set
			{
				SetValue( v =>  _fillStyleTarget = v, _fillStyleTarget, value,  "FillStyleTarget");
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcGlobalOrLocalEnum? @GlobalOrLocal 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _globalOrLocal;
				((IPersistEntity)this).Activate(false);
				return _globalOrLocal;
			} 
			set
			{
				SetValue( v =>  _globalOrLocal = v, _globalOrLocal, value,  "GlobalOrLocal");
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
				case 3: 
					_fillStyleTarget = (IfcPoint)(value.EntityVal);
					return;
				case 4: 
                    _globalOrLocal = (IfcGlobalOrLocalEnum) System.Enum.Parse(typeof (IfcGlobalOrLocalEnum), value.EnumVal, true);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR31:             ('IFC2X3.IFCANNOTATIONFILLAREA' IN TYPEOF (SELF\IfcStyledItem.Item));*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcAnnotationFillAreaOccurrence other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcAnnotationFillAreaOccurrence
            var root = (@IfcAnnotationFillAreaOccurrence)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcAnnotationFillAreaOccurrence left, @IfcAnnotationFillAreaOccurrence right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcAnnotationFillAreaOccurrence left, @IfcAnnotationFillAreaOccurrence right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcAnnotationFillAreaOccurrence x, @IfcAnnotationFillAreaOccurrence y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcAnnotationFillAreaOccurrence obj)
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