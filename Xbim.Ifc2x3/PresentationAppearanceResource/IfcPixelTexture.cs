// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.PresentationAppearanceResource;

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcPixelTexture
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcPixelTexture : IIfcSurfaceTexture
	{
		IfcInteger @Width { get; }
		IfcInteger @Height { get; }
		IfcInteger @ColourComponents { get; }
		IEnumerable<long> @Pixel { get; }
	
	}
}

namespace Xbim.Ifc2x3.PresentationAppearanceResource
{
	[ExpressType("IfcPixelTexture", 728)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcPixelTexture : IfcSurfaceTexture, IInstantiableEntity, IIfcPixelTexture, IEqualityComparer<@IfcPixelTexture>, IEquatable<@IfcPixelTexture>
	{
		#region IIfcPixelTexture explicit implementation
		IfcInteger IIfcPixelTexture.Width { get { return @Width; } }	
		IfcInteger IIfcPixelTexture.Height { get { return @Height; } }	
		IfcInteger IIfcPixelTexture.ColourComponents { get { return @ColourComponents; } }	
		IEnumerable<long> IIfcPixelTexture.Pixel { get { return @Pixel; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPixelTexture(IModel model) : base(model) 		{ 
			Model = model; 
			_pixel = new ItemSet<long>( this, 0 );
		}

		#region Explicit attribute fields
		private IfcInteger _width;
		private IfcInteger _height;
		private IfcInteger _colourComponents;
		private ItemSet<long> _pixel;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcInteger @Width 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _width;
				((IPersistEntity)this).Activate(false);
				return _width;
			} 
			set
			{
				SetValue( v =>  _width = v, _width, value,  "Width");
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcInteger @Height 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _height;
				((IPersistEntity)this).Activate(false);
				return _height;
			} 
			set
			{
				SetValue( v =>  _height = v, _height, value,  "Height");
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcInteger @ColourComponents 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _colourComponents;
				((IPersistEntity)this).Activate(false);
				return _colourComponents;
			} 
			set
			{
				SetValue( v =>  _colourComponents = v, _colourComponents, value,  "ColourComponents");
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.None, 1, -1)]
		public ItemSet<long> @Pixel 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _pixel;
				((IPersistEntity)this).Activate(false);
				return _pixel;
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
				case 4: 
					_width = value.IntegerVal;
					return;
				case 5: 
					_height = value.IntegerVal;
					return;
				case 6: 
					_colourComponents = value.IntegerVal;
					return;
				case 7: 
					if (_pixel == null) _pixel = new ItemSet<long>( this );
					_pixel.InternalAdd(value.HexadecimalVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR21:	WR21 : Width >= 1;*/
		/*WR22:	WR22 : Height >= 1;*/
		/*WR23:	WR23 : {1 <= ColourComponents <= 4};*/
		/*WR24:	WR24 : SIZEOF(Pixel) = (Width * Height);*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcPixelTexture other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcPixelTexture
            var root = (@IfcPixelTexture)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcPixelTexture left, @IfcPixelTexture right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcPixelTexture left, @IfcPixelTexture right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcPixelTexture x, @IfcPixelTexture y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcPixelTexture obj)
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