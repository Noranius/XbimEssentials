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
using Xbim.Ifc4.ProductExtension;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcPort
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcPort : IIfcProduct
	{
		IEnumerable<IIfcRelConnectsPortToElement> @ContainedIn {  get; }
		IEnumerable<IIfcRelConnectsPorts> @ConnectedFrom {  get; }
		IEnumerable<IIfcRelConnectsPorts> @ConnectedTo {  get; }
	
	}
}

namespace Xbim.Ifc4.ProductExtension
{
	[ExpressType("IfcPort", 830)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcPort : IfcProduct, IIfcPort, IEqualityComparer<@IfcPort>, IEquatable<@IfcPort>
	{
		#region IIfcPort explicit implementation
		 
		IEnumerable<IIfcRelConnectsPortToElement> IIfcPort.ContainedIn {  get { return @ContainedIn; } }
		IEnumerable<IIfcRelConnectsPorts> IIfcPort.ConnectedFrom {  get { return @ConnectedFrom; } }
		IEnumerable<IIfcRelConnectsPorts> IIfcPort.ConnectedTo {  get { return @ConnectedTo; } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPort(IModel model) : base(model) 		{ 
			Model = model; 
		}




		#region Inverse attributes
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 0, 1, 20)]
		public IEnumerable<IfcRelConnectsPortToElement> @ContainedIn 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelConnectsPortToElement>(e => (e.RelatingPort as IfcPort) == this);
			} 
		}
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 0, 1, 21)]
		public IEnumerable<IfcRelConnectsPorts> @ConnectedFrom 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelConnectsPorts>(e => (e.RelatedPort as IfcPort) == this);
			} 
		}
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 0, 1, 22)]
		public IEnumerable<IfcRelConnectsPorts> @ConnectedTo 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelConnectsPorts>(e => (e.RelatingPort as IfcPort) == this);
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
				case 6: 
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
        public bool Equals(@IfcPort other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcPort
            var root = (@IfcPort)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcPort left, @IfcPort right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcPort left, @IfcPort right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcPort x, @IfcPort y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcPort obj)
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