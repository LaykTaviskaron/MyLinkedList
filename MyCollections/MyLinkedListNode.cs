﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCollections
{
	public class MyLinkedListNode<T>
	{
		public T Value { get; set; }

		public MyLinkedListNode<T> Previous { get; set; }

		public MyLinkedListNode<T> Next { get; set; }
	}
}
