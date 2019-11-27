using System;


namespace FSKristiansandWebLib.Attributes
{

	//
	// Summary:
	//     When applied to the member of a type, specifies that the member is part of a
	//     data contract and is serializable by the System.Runtime.Serialization.DataContractSerializer.
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
	public sealed class FSProfileAttribute : Attribute
	{
		//
		// Summary:
		//     Initializes a new instance of the System.Runtime.Serialization.DataMemberAttribute
		//     class.
		public FSProfileAttribute() : base() { }

		//
		// Summary:
		//     Gets or sets a data member name.
		//
		// Returns:
		//     The name of the data member. The default is the name of the target that the attribute
		//     is applied to.
		public string Name { get; set; }// { get { return _name; } set { _name = "Me_" + value + "_"; } }
		//private string _name;
		//
		// Summary:
		//     Gets whether System.Runtime.Serialization.DataMemberAttribute.Name has been explicitly
		//     set.
		//
		// Returns:
		//     true if the name has been explicitly set; otherwise, false.
		public bool IsNameSetExplicitly { get; }
		//
		// Summary:
		//     Gets or sets the order of serialization and deserialization of a member.
		//
		// Returns:
		//     The numeric order of serialization or deserialization.
		public int Order { get; set; }
		//
		// Summary:
		//     Gets or sets a value that instructs the serialization engine that the member
		//     must be present when reading or deserializing.
		//
		// Returns:
		//     true, if the member is required; otherwise, false.
		//
		// Exceptions:
		//   T:System.Runtime.Serialization.SerializationException:
		//     the member is not present.
		public bool IsRequired { get; set; }
		//
		// Summary:
		//     Gets or sets a value that specifies whether to serialize the default value for
		//     a field or property being serialized.
		//
		// Returns:
		//     true if the default value for a member should be generated in the serialization
		//     stream; otherwise, false. The default is true.
		public bool EmitDefaultValue { get; set; }
	}
}
