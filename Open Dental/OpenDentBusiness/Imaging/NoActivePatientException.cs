using System;
using System.Collections.Generic;
using System.Text;

namespace OpenDental.Imaging {

	[global::System.Serializable]
	public class NoActivePatientException : Exception {
		//
		// For guidelines regarding the creation of new exception types, see
		//    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/cpgenref/html/cpconerrorraisinghandlingguidelines.asp
		// and
		//    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/dncscol/html/csharp07192001.asp
		//

		public NoActivePatientException() { }
		public NoActivePatientException(string message) : base(message) { }
		public NoActivePatientException(string message, Exception inner) : base(message, inner) { }
		protected NoActivePatientException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context)
			: base(info, context) { }
	}
}
