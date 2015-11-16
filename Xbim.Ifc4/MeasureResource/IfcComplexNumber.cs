// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.MeasureResource
{
	[ExpressType("IfcComplexNumber", 12)]
    // ReSharper disable once PartialTypeWithSinglePart
	public partial struct IfcComplexNumber : IfcMeasureValue, IExpressComplexType, System.IEquatable<List<double>>
	{ 
		private List<double> _value;
        
		public static void Add(ref IfcComplexNumber comp, double component)
        {
            if (comp._value == null)
                comp.Initialise(component);
            else
                comp._value.Add(component);
        }

		private void Initialise(double comp)
        {
            _value = new List<double>{ comp };
        }

		public object Value
        {
            get { return _value; }
        }

        public IfcComplexNumber(List<double> val)
        {
			//copy items into new inner list
			_value = new List<double>(val);
        }


        public static implicit operator IfcComplexNumber(List<double> value)
        {
            return new IfcComplexNumber(value);
        }

        public static implicit operator List<double>(IfcComplexNumber obj)
        {
			//return copy so that underlying collection is not exposed
			return new List<double>(obj._value);

        }


        public override bool Equals(object obj)
        {
			if (obj == null && Value == null)
                return true;

            if (obj == null)
                return false;

            if (GetType() != obj.GetType())
                return false;

            return System.Linq.Enumerable.SequenceEqual(((IfcComplexNumber) obj)._value, _value);
        }

		public bool Equals(List<double> other)
	    {
	        return this == other;
	    }

        public static bool operator ==(IfcComplexNumber obj1, IfcComplexNumber obj2)
        {
            return Equals(obj1, obj2);
        }

        public static bool operator !=(IfcComplexNumber obj1, IfcComplexNumber obj2)
        {
            return !Equals(obj1, obj2);
        }

        public override int GetHashCode()
        {
            return Value != null ? _value.Sum(o => o.GetHashCode()) : base.GetHashCode();
        }

		#region IPersist implementation
		void IPersist.Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			if (propIndex != 0)
				throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			if (_value == null)
				_value = new List<double>();
            _value.Add(value.RealVal);
            
		}

		string IPersist.WhereRule()
		{
            throw new System.NotImplementedException();
		}
		#endregion

		#region IExpressValueType implementation
        System.Type IExpressValueType.UnderlyingSystemType { 
			get 
			{
				return typeof(List<double>);
			}
		}
		#endregion

		#region IExpressComplexType implementation
		IEnumerable<object> IExpressComplexType.Properties
        {
            get
            {
				if(_value == null) yield break;
	            foreach (var value in _value)
	                yield return value;
            }
        }
		#endregion

	}
}
