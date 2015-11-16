using System.Collections.Generic;
using System.Linq.Expressions;
using System;

namespace Xbim.Common
{
	public interface IEntityCollection: IReadOnlyEntityCollection
	{

        IPersistEntity New(Type t);
        T New<T>(Action<T> initPropertiesFunc) where T : IInstantiableEntity;
        T New<T>() where T : IInstantiableEntity;
        IPersistEntity this[int label] { get; }
        
	}

	public interface IReadOnlyEntityCollection : IEnumerable<IPersistEntity>
    {
		IEnumerable<T> Where<T>(Expression<Func<T, bool>> expr) where T : IPersistEntity;
        T FirstOrDefault<T>() where T : IPersistEntity;
		T FirstOrDefault<T>(Expression<Func<T, bool>> expr) where T : IPersistEntity;
        IEnumerable<T> OfType<T>() where T : IPersistEntity;
        IEnumerable<T> OfType<T>(bool activate) where T : IPersistEntity;
        IEnumerable<IPersistEntity> OfType(string stringType, bool activate);
		long Count { get; }
        long CountOf<T>() where T : IPersistEntity;
    }
}