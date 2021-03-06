﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HellBrick.Collections;

namespace HellBrick.AsyncCollections.Benchmark
{
	class NitoAsyncCollectionAdapter<T>: IAsyncCollection<T>
	{
		private Nito.AsyncEx.AsyncCollection<T> _collection;

		public NitoAsyncCollectionAdapter()
		{
			_collection = new Nito.AsyncEx.AsyncCollection<T>();
		}

		#region IAsyncCollection<T> Members

		public int AwaiterCount
		{
			get { throw new NotImplementedException(); }
		}

		public void Add( T item )
		{
			_collection.Add( item );
		}

		public Task<T> TakeAsync( System.Threading.CancellationToken cancellationToken )
		{
			return _collection.TakeAsync( cancellationToken );
		}

		#endregion

		#region IEnumerable<T> Members

		public IEnumerator<T> GetEnumerator()
		{
			throw new NotImplementedException();
		}

		#endregion

		#region IEnumerable Members

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			throw new NotImplementedException();
		}

		#endregion

		#region ICollection Members

		public void CopyTo( Array array, int index )
		{
			throw new NotImplementedException();
		}

		public int Count
		{
			get { throw new NotImplementedException(); }
		}

		public bool IsSynchronized
		{
			get { throw new NotImplementedException(); }
		}

		public object SyncRoot
		{
			get { throw new NotImplementedException(); }
		}

		#endregion
	}
}
