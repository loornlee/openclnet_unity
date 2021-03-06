using System;

[System.Serializable]
public class UnityCLException : System.Exception
{
		public UnityCLException(OpenCL.Net.ErrorCode error):base(UnityCL.ErrorText(error)){
		}	

		/// <summary>
		/// Initializes a new instance of the <see cref="T:UnityCLException"/> class
		/// </summary>
		public UnityCLException ()
		{
		}
	
		/// <summary>
		/// Initializes a new instance of the <see cref="T:UnityCLException"/> class
		/// </summary>
		/// <param name="message">A <see cref="T:System.String"/> that describes the exception. </param>
		public UnityCLException (string message) : base (message)
		{
		}
	
		/// <summary>
		/// Initializes a new instance of the <see cref="T:UnityCLException"/> class
		/// </summary>
		/// <param name="message">A <see cref="T:System.String"/> that describes the exception. </param>
		/// <param name="inner">The exception that is the cause of the current exception. </param>
		public UnityCLException (string message, System.Exception inner) : base (message, inner)
		{
		}
	
		/// <summary>
		/// Initializes a new instance of the <see cref="T:UnityCLException"/> class
		/// </summary>
		/// <param name="context">The contextual information about the source or destination.</param>
		/// <param name="info">The object that holds the serialized object data.</param>
		protected UnityCLException (System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base (info, context)
		{
		}
}
