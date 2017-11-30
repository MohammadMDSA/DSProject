using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace DSProject0.Util
{
	public class LinkedList<T>
	{
		public int Length { get; private set; }
		private LinkedListNode<T> _FirstNode;
		private LinkedListNode<T> _LastNode;

		public LinkedList()
		{
			_FirstNode = _LastNode = null;
			Length = 0;
		}

		public LinkedList<T> AddLast(T data)
		{
			var newNode = new LinkedListNode<T>();
			newNode.Data = data;
			newNode.PreviousNode = _LastNode;
			_LastNode = newNode;
			if (this.Length == 0)
				_FirstNode = newNode;
			Length++;

			return this;
		}

		public LinkedListNode<T> FirstNode
		{
			get { if (Length == 0) throw new EmptyLinkedListException("The arraylist is empty"); else return _FirstNode; }
		}
		public LinkedListNode<T> LastNode
		{
			get { if (Length == 0) throw new EmptyLinkedListException("The arraylist is empty"); else return _LastNode; }
		}

	}

	public class EmptyLinkedListException : Exception
	{
		public EmptyLinkedListException(string message) : base(message) { }
	}

	public sealed class LinkedListNode<V>
	{
		public V Data { get; set; }
		public LinkedListNode<V> NextNode { get; set; }
		public LinkedListNode<V> PreviousNode { get; set; }

		public LinkedListNode(V data) : this()
		{
			this.Data = data;
		}

		public LinkedListNode()
		{
			this.NextNode = null;
			this.PreviousNode = null;
		}
	}
}
