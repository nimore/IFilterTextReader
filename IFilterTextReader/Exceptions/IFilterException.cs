using System;

namespace IFilterTextReader.Exceptions
{
	[Serializable]
	public abstract class IFilterException : Exception
	{
		protected internal IFilterException()
		{
		}

		protected internal IFilterException(string message)
			: base(message)
		{
		}

		protected internal IFilterException(string message, Exception inner)
			: base(message, inner)
		{
		}

		protected IFilterException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context)
			: base(info, context) { }
	}
}
