using System.Globalization;

#region "copy of ../../build/common/SR.cs"

namespace System.Runtime.Serialization
{
	static partial class SR 
	{

        internal static string GetString(string name, params object[] args)
        {
                return GetString (CultureInfo.InvariantCulture, name, args);
        }

        internal static string GetString(CultureInfo culture, string name, params object[] args) {
                return string.Format (culture, name, args);
        }

        internal static string GetString(string name)
        {
                return name;
        }

        internal static string GetString(CultureInfo culture, string name)
        {
                return name;
        }
}
}

/*
namespace System.Text
{
	static partial class SR
	{
        internal static string GetString(string name, params object[] args)
        {
                return GetString (CultureInfo.InvariantCulture, name, args);
        }

        internal static string GetString(CultureInfo culture, string name, params object[] args) {
                return string.Format (culture, name, args);
        }

        internal static string GetString(string name)
        {
                return name;
        }

        internal static string GetString(CultureInfo culture, string name)
        {
                return name;
        }
}
}

namespace System.Xml
{
	static partial class SR
	{
        internal static string GetString(string name, params object[] args)
        {
                return GetString (CultureInfo.InvariantCulture, name, args);
        }

        internal static string GetString(CultureInfo culture, string name, params object[] args) {
                return string.Format (culture, name, args);
        }

        internal static string GetString(string name)
        {
                return name;
        }

        internal static string GetString(CultureInfo culture, string name)
        {
                return name;
        }
}
}
*/
#endregion


#region "retrieved string resources"

namespace System.Runtime.Serialization
{
	static partial class SR {


public const string ArrayExceededSize = @"Array length '{0}' provided by the get-only collection of type '{1}' is less than the number of array elements found in the input stream.  Consider increasing the length of the array.";
public const string ArrayExceededSizeAttribute = @"Array length '{0}' provided by Size attribute is not equal to the number of array elements '{1}' from namespace '{2}' found.";
public const string ArrayTypeIsNotSupported = @"An internal error has occurred. '{0}[]' is not supported when generating code for serialization.";
public const string CannotDeserializeRefAtTopLevel = @"Cannot deserialize since root element references unrecognized object with id '{0}'.";
public const string CannotLoadMemberType = @"Cannot load member type '{0}'.";
public const string CannotSerializeObjectWithCycles = @"Object graph for type '{0}' contains cycles and cannot be serialized if references are not tracked. Consider using the DataContractAttribute with the IsReference property set to true.";
public const string CanOnlyStoreIntoArgOrLocGot0 = @"An internal error has occurred. Data can only be stored into ArgBuilder or LocalBuilder. Got: {0}.";
public const string CharIsInvalidPrimitive = @"An internal error has occurred. Char is not a valid schema primitive and should be treated as int in DataContract.";
public const string CallbackMustReturnVoid = @"Serialization Callback '{1}' in type '{0}' must return void. ";
public const string CallbackParameterInvalid = @"Serialization Callback '{1}' in type '{0}' must have a single parameter of type '{2}'. ";
public const string CallbacksCannotBeVirtualMethods = @"Virtual Method '{0}' of type '{1}' cannot be marked with '{2}' attribute. ";
public const string CollectionMustHaveAddMethod = @"Collection type '{0}' does not have a valid Add method.";
public const string CollectionMustHaveGetEnumeratorMethod = @"Collection type '{0}' does not have a valid GetEnumerator method.";
public const string CollectionMustHaveItemType = @"Collection type '{0}' must have a non-null item type.";
public const string CollectionTypeCannotBeBuiltIn = @"{0} is a built-in type and cannot be a collection.";
public const string CollectionTypeCannotHaveDataContract = @"{0} has DataContractAttribute attribute.";
public const string CollectionTypeDoesNotHaveAddMethod = @"{0} does not have a valid Add method with parameter of type '{1}'.";
public const string CollectionTypeDoesNotHaveDefaultCtor = @"{0} does not have a default constructor.";
public const string CollectionTypeHasMultipleDefinitionsOfInterface = @"{0} has multiple definitions of interface '{1}'.";
public const string CollectionTypeIsNotIEnumerable = @"{0} does not implement IEnumerable interface.";
public const string DataContractCacheOverflow = @"An internal error has occurred. DataContract cache overflow.";
public const string DataContractNamespaceAlreadySet = @"ContractNamespaceAttribute attribute maps CLR namespace '{2}' to multiple data contract namespaces '{0}' and '{1}'. You can map a CLR namespace to only one data contract namespace.";
public const string DataContractNamespaceIsNotValid = @"DataContract namespace '{0}' is not a valid URI.";
public const string DataContractNamespaceReserved = @"DataContract namespace '{0}' cannot be specified since it is reserved.";
public const string DataMemberOnEnumField = @"Member '{0}.{1}' has DataMemberAttribute attribute. Use EnumMemberAttribute attribute instead.";
public const string DcTypeNotFoundOnDeserialize = @"Element '{2}:{3}' contains data of the '{0}:{1}' data contract. The deserializer has no knowledge of any type that maps to this contract. Add the type corresponding to '{1}' to the list of known types - for example, by using the KnownTypeAttribute attribute or by adding it to the list of known types passed to DataContractSerializer.";
public const string DcTypeNotFoundOnSerialize = @"Type '{0}' with data contract name '{1}:{2}' is not expected. Add any types not known statically to the list of known types - for example, by using the KnownTypeAttribute attribute or by adding them to the list of known types passed to DataContractSerializer.";
public const string DcTypeNotResolvedOnDeserialize = @"Element '{2}:{3}' contains data from a type that maps to the name '{0}:{1}'. The deserializer has no knowledge of any type that maps to this name. Consider changing the implementation of the ResolveName method on your DataContractResolver to return a non-null value for name '{1}' and namespace '{0}'.";
public const string DeserializedObjectWithIdNotFound = @"Deserialized object with reference id '{0}' not found in stream.";
public const string DupContractInKnownTypes = @"Type '{0}' cannot be added to list of known types since another type '{1}' with the same data contract name '{2}:{3}' is already present.";
public const string DupKeyValueName = @"The collection data contract type '{0}' specifies the same value '{1}' for both the KeyName and the ValueName properties. This is not allowed. Consider changing either the KeyName or the ValueName property.";
public const string DupEnumMemberValue = @"Type '{2}' contains two members '{0}' 'and '{1}' with the same name '{3}'. Multiple members with the same name in one type are not supported. Consider changing one of the member names using EnumMemberAttribute attribute.";
public const string DupMemberName = @"Type '{2}' contains two members '{0}' 'and '{1}' with the same data member name '{3}'. Multiple members with the same name in one type are not supported. Consider changing one of the member names using DataMemberAttribute attribute.";
public const string DuplicateAttribute = @"Invalid Callback. Method '{3}' in type '{2}' has both '{0}' and '{1}'. ";
public const string DuplicateCallback = @"Invalid attribute. Both '{0}' and '{1}' in type '{2}' have '{3}'. ";
public const string EncounteredWithNameNamespace = @"{0}. Encountered '{1}'  with name '{2}', namespace '{3}'.";
public const string EnumTypeCannotHaveIsReference = @"Enum type '{0}' cannot have the IsReference setting of '{1}'. Either change the setting to '{2}', or remove it completely.";
public const string ErrorDeserializing = @"There was an error deserializing the object {0}. {1}";
public const string ErrorInLine = @"Error in line {0} position {1}.";
public const string ErrorIsStartObject = @"There was an error checking start element of object {0}. {1}";
public const string ErrorSerializing = @"There was an error serializing the object {0}. {1}";
public const string ErrorTypeInfo = @"of type {0}";
public const string ErrorWriteEndObject = @"There was an error writing end element of object {0}. {1}";
public const string ErrorWriteStartObject = @"There was an error writing start element of object {0}. {1}";
public const string ExceededMaxItemsQuota = @"Maximum number of items that can be serialized or deserialized in an object graph is '{0}'.";
public const string ExpectingElement = @"Expecting element '{1}' from namespace '{0}'.";
public const string ExpectingElementAtDeserialize = @"Expecting state '{0}' when ReadObject is called.";
public const string ExpectingEnd = @"Expecting End'{0}'.";
public const string ExpectingState = @"Expecting state '{0}'.";
public const string GenericNameBraceMismatch = @"The data contract name '{0}' for type '{1}' has a curly brace '{{' that is not matched with a closing curly brace. Curly braces have special meaning in data contract names - they are used to customize the naming of data contracts for generic types.";
public const string GenericParameterNotValid = @"In the data contract name for type '{1}', there are curly braces with '{0}' inside, which is an invalid value. Curly braces have special meaning in data contract names - they are used to customize the naming of data contracts for generic types. Based on the number of generic parameters this type has, the contents of the curly braces must either be a number between 0 and '{2}' to insert the name of the generic parameter at that index or the '#' symbol to insert a digest of the generic parameter namespaces.";
public const string InconsistentIsReference = @"The IsReference setting for type '{0}' is '{1}', but the same setting for its parent class '{2}' is '{3}'. Derived types must have the same value for IsReference as the base type. Change the setting on type '{0}' to '{3}', or on type '{2}' to '{1}', or do not set IsReference explicitly.";
public const string IndexedPropertyCannotBeSerialized = @"Property '{1}' in type '{0}' cannot be serialized because serialization of indexed properties is not supported.";
public const string InterfaceTypeCannotBeCreated = @"Interface type '{0}' cannot be created. Consider replacing with a non-interface serializable type.";
public const string InvalidCollectionContractItemName = @"Type '{0}' cannot have CollectionDataContractAttribute attribute ItemName set to null or empty string.";
public const string InvalidCollectionContractKeyName = @"Type '{0}' cannot have CollectionDataContractAttribute attribute KeyName set to null or empty string.";
public const string InvalidCollectionContractKeyNoDictionary = @"The collection data contract type '{0}' specifies '{1}' for the KeyName property. This is not allowed since the type is not IDictionary. Remove the setting for the KeyName property.";
public const string InvalidCollectionContractName = @"Type '{0}' cannot have CollectionDataContractAttribute attribute Name set to null or empty string.";
public const string InvalidCollectionContractNamespace = @"Type '{0}' cannot have CollectionDataContractAttribute attribute Namespace set to null.";
public const string InvalidCollectionContractValueName = @"Type '{0}' cannot have CollectionDataContractAttribute attribute ValueName set to null or empty string.";
public const string InvalidCollectionContractValueNoDictionary = @"The collection data contract type '{0}' specifies '{1}' for the ValueName property. This is not allowed since the type is not IDictionary. Remove the setting for the ValueName property.";
public const string InvalidCollectionDataContract = @"Type '{0}' with CollectionDataContractAttribute attribute is an invalid collection type since it";
public const string InvalidCollectionType = @"Type '{0}' is an invalid collection type since it";
public const string InvalidDataContractName = @"Type '{0}' cannot have DataContractAttribute attribute Name set to null or empty string.";
public const string InvalidDataContractNamespace = @"Type '{0}' cannot have DataContractAttribute attribute Namespace set to null.";
public const string InvalidDataMemberName = @"Member '{0}' in type '{1}' cannot have DataMemberAttribute attribute Name set to null or empty string.";
public const string InvalidEnumMemberValue = @"'{0}' in type '{1}' cannot have EnumMemberAttribute attribute Value set to null or empty string.";
public const string InvalidEnumValueOnRead = @"Invalid enum value '{0}' cannot be deserialized into type '{1}'. Ensure that the necessary enum values are present and are marked with EnumMemberAttribute attribute if the type has DataContractAttribute attribute.";
public const string InvalidEnumValueOnWrite = @"Enum value '{0}' is invalid for type '{1}' and cannot be serialized. Ensure that the necessary enum values are present and are marked with EnumMemberAttribute attribute if the type has DataContractAttribute attribute.";
public const string InvalidGetSchemaMethod = @"Type '{0}' cannot have MethodName on XmlSchemaProviderAttribute attribute set to null or empty string. ";
public const string InvalidGlobalDataContractNamespace = @"CLR namespace '{0}' cannot have ContractNamespace set to null.";
public const string InvalidMember = @"Member '{0}.{1}' cannot be serialized since it is neither a field nor a property, and therefore cannot be marked with the DataMemberAttribute attribute. Remove the DataMemberAttribute attribute from the '{1}' member.";
public const string InvalidNonNullReturnValueByIsAny = @"Method '{0}.{1}()' returns a non-null value. The return value must be null since IsAny=true.";
public const string InvalidPrimitiveType = @"Type '{0}' is not a valid serializable type.";
public const string InvalidReturnTypeOnGetSchemaMethod = @"Method '{0}.{1}()' returns '{2}'. The return type must be compatible with '{3}'.";
public const string InvalidSizeDefinition = @"Invalid Size '{0}'. Must be non-negative integer.";
public const string InvalidXmlDataContractName = @"XML data contract Name for type '{0}' cannot be set to null or empty string.";
public const string InvalidXsIdDefinition = @"Invalid Id '{0}'. Must not be null or empty.";
public const string InvalidXsRefDefinition = @"Invalid Ref '{0}'. Must not be null or empty.";
public const string IsAnyCannotBeNull = @"A null value cannot be serialized at the top level for IXmlSerializable root type '{0}' since its IsAny setting is 'true'. This type must write all its contents including the root element. Verify that the IXmlSerializable implementation is correct.";
public const string IsAnyCannotBeSerializedAsDerivedType = @"An object of type '{0}' cannot be serialized at the top level for IXmlSerializable root type '{1}' since its IsAny setting is 'true'. This type must write all its contents including the root element. Verify that the IXmlSerializable implementation is correct.";
public const string IsAnyCannotHaveXmlRoot = @"Type '{0}' cannot specify an XmlRootAttribute attribute because its IsAny setting is 'true'. This type must write all its contents including the root element. Verify that the IXmlSerializable implementation is correct.";
public const string IsNotAssignableFrom = @"An internal error has occurred. '{0}' is not assignable from '{1}' - error generating code for serialization.";
public const string IsRequiredDataMemberOnIsReferenceDataContractType = @"'{0}.{1}' has the IsRequired setting of '{2}. However, '{0}' has the IsReference setting of '{2}', because either it is set explicitly, or it is derived from a base class. Set IsRequired on '{0}.{1}' to false, or disable IsReference on '{0}'.";
public const string IXmlSerializableCannotHaveCollectionDataContract = @"Type '{0}' cannot be IXmlSerializable and have CollectionDataContractAttribute attribute.";
public const string IXmlSerializableCannotHaveDataContract = @"Type '{0}' cannot be IXmlSerializable and have DataContractAttribute attribute.";
public const string IXmlSerializableIllegalOperation = @"This method cannot be called from IXmlSerializable implementations.";
public const string IXmlSerializableMissingEndElements = @"IXmlSerializable.WriteXml method of type '{0}' did not close all open tags. Verify that the IXmlSerializable implementation is correct.";
public const string IXmlSerializableMustHaveDefaultConstructor = @"IXmlSerializable Type '{0}' must have default constructor.";
public const string IXmlSerializableWritePastSubTree = @"IXmlSerializable.WriteXml method of type '{0}' attempted to close too many tags.  Verify that the IXmlSerializable implementation is correct.";
public const string KnownTypeAttributeEmptyString = @"Method name specified by KnownTypeAttribute attribute on type '{0}' cannot be the empty string.";
public const string KnownTypeAttributeUnknownMethod = @"KnownTypeAttribute attribute on type '{1}' specifies a method named '{0}' to provide known types. Static method '{0}()' was not found on this type. Ensure that the method exists and is marked as static.";
public const string KnownTypeAttributeReturnType = @"KnownTypeAttribute attribute on type '{0}' specifies a method named '{1}' to provide known types. The return type of this method is invalid because it is not assignable to IEnumerable<Type>. Ensure that the method exists and has a valid signature.";
public const string KnownTypeAttributeOneScheme = @"Type '{0}': If a KnownTypeAttribute attribute specifies a method it must be the only KnownTypeAttribute attribute on that type.";
public const string KnownTypeAttributeNoType = @"KnownTypeAttribute attribute on type '{0}' contains no Type.";
public const string KnownTypeConfigClosedGenericDeclared = @"Declared type '{0}' in config cannot be a closed or partial generic type.";
public const string KnownTypeAttributeValidMethodTypes = @"Method specified by KnownTypeAttribute attribute on type '{0}' does not expose valid types.";
public const string KnownTypeAttributeNoData = @"KnownTypeAttribute attribute on type '{0}' contains no data.";
public const string KnownTypeAttributeMethodNull = @"Method specified by KnownTypeAttribute attribute on type '{0}' returned null.";
public const string MaxArrayLengthExceeded = @"The maximum array length ({0}) has been exceeded while reading XML data for array of type '{1}'.";
public const string MissingGetSchemaMethod = @"Type '{0}' does not have a static method '{1}' that takes a parameter of type 'System.Xml.Schema.XmlSchemaSet' as specified by the XmlSchemaProviderAttribute attribute.";
public const string MultipleIdDefinition = @"Invalid XML encountered. The same Id value '{0}' is defined more than once. Multiple objects cannot be deserialized using the same Id.";
public const string NoConversionPossibleTo = @"An internal error has occurred. No conversion is possible to '{0}' - error generating code for serialization.";
public const string NoGetMethodForProperty = @"No get method for property '{1}' in type '{0}'.";
public const string NoSetMethodForProperty = @"No set method for property '{1}' in type '{0}'.";
public const string NullKnownType = @"One of the known types provided to the serializer via '{0}' argument was invalid because it was null. All known types specified must be non-null values.";
public const string NullValueReturnedForGetOnlyCollection = @"The get-only collection of type '{0}' returned a null value.  The input stream contains collection items which cannot be added if the instance is null.  Consider initializing the collection either in the constructor of the the object or in the getter.";
public const string ObjectTableOverflow = @"An internal error has occurred. Object table overflow. This could be caused by serializing or deserializing extremely large object graphs.";
public const string OrderCannotBeNegative = @"Property 'Order' in DataMemberAttribute attribute cannot be a negative number.";
public const string ParameterCountMismatch = @"Invalid number of parameters to call method '{0}'. Expected '{1}' parameters, but '{2}' were provided.";
public const string PartialTrustCollectionContractAddMethodNotPublic = @"The collection data contract type '{0}' cannot be deserialized because the method '{1}' is not public. Making the method public will fix this error. Alternatively, you can make it internal, and use the InternalsVisibleToAttribute attribute on your assembly in order to enable serialization of internal members - see documentation for more details. Be aware that doing so has certain security implications.";
public const string PartialTrustCollectionContractNoPublicConstructor = @"The collection data contract type '{0}' cannot be deserialized because it does not have a public parameterless constructor. Adding a public parameterless constructor will fix this error. Alternatively, you can make it internal, and use the InternalsVisibleToAttribute attribute on your assembly in order to enable serialization of internal members - see documentation for more details. Be aware that doing so has certain security implications.";
public const string PartialTrustCollectionContractTypeNotPublic = @"The collection data contract type '{0}' cannot be deserialized because it does not have a public parameterless constructor. Adding a public parameterless constructor will fix this error. Alternatively, you can make it internal, and use the InternalsVisibleToAttribute attribute on your assembly in order to enable serialization of internal members - see documentation for more details. Be aware that doing so has certain security implications.";
public const string PartialTrustDataContractOnSerializingNotPublic = @"The data contract type '{0}' cannot be serialized because the OnSerializing method '{1}' is not public. Making the method public will fix this error. Alternatively, you can make it internal, and use the InternalsVisibleToAttribute attribute on your assembly in order to enable serialization of internal members - see documentation for more details. Be aware that doing so has certain security implications.";
public const string PartialTrustDataContractOnSerializedNotPublic = @"The data contract type '{0}' cannot be serialized because the OnSerialized method '{1}' is not public. Making the method public will fix this error. Alternatively, you can make it internal, and use the InternalsVisibleToAttribute attribute on your assembly in order to enable serialization of internal members - see documentation for more details. Be aware that doing so has certain security implications.";
public const string PartialTrustDataContractOnDeserializingNotPublic = @"The data contract type '{0}' cannot be deserialized because the OnDeserializing method '{1}' is not public. Making the method public will fix this error. Alternatively, you can make it internal, and use the InternalsVisibleToAttribute attribute on your assembly in order to enable serialization of internal members - see documentation for more details. Be aware that doing so has certain security implications.";
public const string PartialTrustDataContractOnDeserializedNotPublic = @"The data contract type '{0}' cannot be deserialized because the OnDeserialized method '{1}' is not public. Making the method public will fix this error. Alternatively, you can make it internal, and use the InternalsVisibleToAttribute attribute on your assembly in order to enable serialization of internal members - see documentation for more details. Be aware that doing so has certain security implications.";
public const string PartialTrustDataContractFieldGetNotPublic = @"The data contract type '{0}' cannot be serialized because the member '{1}' is not public. Making the member public will fix this error. Alternatively, you can make it internal, and use the InternalsVisibleToAttribute attribute on your assembly in order to enable serialization of internal members - see documentation for more details. Be aware that doing so has certain security implications.";
public const string PartialTrustDataContractFieldSetNotPublic = @"The data contract type '{0}' cannot be deserialized because the member '{1}' is not public. Making the member public will fix this error. Alternatively, you can make it internal, and use the InternalsVisibleToAttribute attribute on your assembly in order to enable serialization of internal members - see documentation for more details. Be aware that doing so has certain security implications.";
public const string PartialTrustDataContractPropertyGetNotPublic = @"The data contract type '{0}' cannot be serialized because the property '{1}' does not have a public getter. Adding a public getter will fix this error. Alternatively, you can make it internal, and use the InternalsVisibleToAttribute attribute on your assembly in order to enable serialization of internal members - see documentation for more details. Be aware that doing so has certain security implications.";
public const string PartialTrustDataContractPropertySetNotPublic = @"The data contract type '{0}' cannot be deserialized because the property '{1}' does not have a public setter. Adding a public setter will fix this error. Alternatively, you can make it internal, and use the InternalsVisibleToAttribute attribute on your assembly in order to enable serialization of internal members - see documentation for more details. Be aware that doing so has certain security implications.";
public const string PartialTrustDataContractTypeNotPublic = @"The data contract type '{0}' is not serializable because it is not public. Making the type public will fix this error. Alternatively, you can make it internal, and use the InternalsVisibleToAttribute attribute on your assembly in order to enable serialization of internal members - see documentation for more details. Be aware that doing so has certain security implications.";
public const string PartialTrustNonAttributedSerializableTypeNoPublicConstructor = @"The type '{0}' cannot be deserialized because it does not have a public parameterless constructor. Alternatively, you can make it internal, and use the InternalsVisibleToAttribute attribute on your assembly in order to enable serialization of internal members - see documentation for more details. Be aware that doing so has certain security implications.";
public const string PartialTrustIXmlSerializableTypeNotPublic = @"The IXmlSerializable type '{0}' is not serializable in partial trust because it is not public. Adding a public parameterless constructor will fix this error. Alternatively, you can make it internal, and use the InternalsVisibleToAttribute attribute on your assembly in order to enable serialization of internal members - see documentation for more details. Be aware that doing so has certain security implications.";
public const string PartialTrustIXmlSerialzableNoPublicConstructor = @"The IXmlSerializable type '{0}' cannot be deserialized because it does not have a public parameterless constructor. Adding a public parameterless constructor will fix this error. Alternatively, you can make it internal, and use the InternalsVisibleToAttribute attribute on your assembly in order to enable serialization of internal members - see documentation for more details. Be aware that doing so has certain security implications.";
public const string NonAttributedSerializableTypesMustHaveDefaultConstructor = @"The Type '{0}' must have a parameterless constructor.";
public const string AttributedTypesCannotInheritFromNonAttributedSerializableTypes = @"Type '{0}' cannot inherit from a type that is not marked with DataContractAttribute or SerializableAttribute.  Consider marking the base type '{1}' with DataContractAttribute or SerializableAttribute, or removing them from the derived type.";
public const string GetOnlyCollectionsNotSupported = @"Get-only collection properties are not supported.  Consider adding a public setter to property '{0}.{1}' or marking the it with the IgnoreDataMemberAttribute. ";
public const string QuotaMustBePositive = @"Quota must be a positive value.";
public const string QuotaIsReadOnly = @"The '{0}' quota is readonly.";
public const string QuotaCopyReadOnly = @"Cannot copy XmlDictionaryReaderQuotas. Target is readonly.";
public const string RequiredMemberMustBeEmitted = @"Member {0} in type {1} cannot be serialized. This exception is usually caused by trying to use a null value where a null value is not allowed. The '{0}' member is set to its default value (usually null or zero). The member's EmitDefault setting is 'false', indicating that the member should not be serialized. However, the member's IsRequired setting is 'true', indicating that it must be serialized. This conflict cannot be resolved.  Consider setting '{0}' to a non-default value. Alternatively, you can change the EmitDefaultValue property on the DataMemberAttribute attribute to true, or changing the IsRequired property to false.";
public const string ResolveTypeReturnedFalse = @"An object of type '{0}' which derives from DataContractResolver returned false from its TryResolveType method when attempting to resolve the name for an object of type '{1}', indicating that the resolution failed. Change the TryResolveType implementation to return true.";
public const string ResolveTypeReturnedNull = @"An object of type '{0}' which derives from DataContractResolver returned a null typeName or typeNamespace but not both from its TryResolveType method when attempting to resolve the name for an object of type '{1}'. Change the TryResolveType implementation to return non-null values, or to return null values for both typeName and typeNamespace in order to serialize as the declared type.";
public const string SupportForMultidimensionalArraysNotPresent = @"Multi-dimensional arrays are not supported.";
public const string TooManyCollectionContracts = @"Type '{0}' has more than one CollectionDataContractAttribute attribute.";
public const string TooManyDataContracts = @"Type '{0}' has more than one DataContractAttribute attribute.";
public const string TooManyDataMembers = @"Member '{0}.{1}' has more than one DataMemberAttribute attribute.";
public const string TooManyEnumMembers = @"Member '{0}.{1}' has more than one EnumMemberAttribute attribute.";
public const string TooManyIgnoreDataMemberAttributes = @"Member '{0}.{1}' has more than one IgnoreDataMemberAttribute attribute.";
public const string TypeMustBeConcrete = @"Error while getting known types for Type '{0}'. The type must not be an open or partial generic class.";
public const string TypeNotSerializable = @"Type '{0}' cannot be serialized. Consider marking it with the DataContractAttribute attribute, and marking all of its members you want serialized with the DataMemberAttribute attribute. Alternatively, you can ensure that the type is public and has a parameterless constructor - all public members of the type will then be serialized, and no attributes will be required.";
public const string UnexpectedContractType = @"An internal error has occurred. Unexpected contract type '{0}' for type '{1}' encountered.";
public const string UnexpectedElementExpectingElements = @"'{0}' '{1}' from namespace '{2}' is not expected. Expecting element '{3}'.";
public const string UnexpectedEndOfFile = @"Unexpected end of file.";
public const string UnknownConstantType = @"Unrecognized constant type '{0}'.";
public const string UnsupportedIDictionaryAsDataMemberType = @"Cannot deserialize one of the DataMember because it is an IDictionary. Use IDictionary<K,V> instead.";
public const string ValueMustBeNonNegative = @"The value of this argument must be non-negative.";
public const string ValueTypeCannotBeNull = @"ValueType '{0}' cannot be null.";
public const string ValueTypeCannotHaveBaseType = @"Data contract '{0}' from namespace '{1}' is a value type and cannot have base contract '{2}' from namespace '{3}'.";
public const string ValueTypeCannotHaveId = @"ValueType '{0}' cannot have id.";
public const string ValueTypeCannotHaveIsReference = @"Value type '{0}' cannot have the IsReference setting of '{1}'. Either change the setting to '{2}', or remove it completely. ";
public const string ValueTypeCannotHaveRef = @"ValueType '{0}' cannot have ref to another object.";
public const string XmlElementAttributes = @"Only Element nodes have attributes.";
public const string XmlForObjectCannotHaveContent = @"Element {0} from namespace {1} cannot have child contents to be deserialized as an object. Please use XElement to deserialize this pattern of XML.";
public const string XmlInvalidConversion = @"The value '{0}' cannot be parsed as the type '{1}'.";
public const string XmlInvalidConversionWithoutValue = @"The value cannot be parsed as the type '{0}'.";
public const string XmlStartElementExpected = @"Start element expected. Found {0}.";
public const string XmlWriterMustBeInElement = @"WriteState '{0}' not valid. Caller must write start element before serializing in contentOnly mode.";

	}
}

namespace System.Runtime.Serialization
{
	static partial class SR {

public const string OffsetExceedsBufferSize = @"The specified offset exceeds the buffer size ({0} bytes).";
public const string SizeExceedsRemainingBufferSpace = @"The specified size exceeds the remaining buffer space ({0} bytes).";
public const string ValueMustBeInRange = @"The value of this argument must fall within the range {0} to {1}.";
public const string XmlArrayTooSmallOutput = @"Array too small.  Must be able to hold at least {0}.";
public const string XmlInvalidBase64Length = @"Base64 sequence length ({0}) not valid. Must be a multiple of 4.";
public const string XmlInvalidBase64Sequence = @"The characters '{0}' at offset {1} are not a valid Base64 sequence.";
public const string XmlInvalidBinHexLength = @"BinHex sequence length ({0}) not valid. Must be a multiple of 2.";
public const string XmlInvalidBinHexSequence = @"The characters '{0}' at offset {1} are not a valid BinHex sequence.";
public const string XmlInvalidHighSurrogate = @"High surrogate char '0x{0}' not valid. High surrogate chars range from 0xD800 to 0xDBFF.";
public const string XmlInvalidLowSurrogate = @"Low surrogate char '0x{0}' not valid. Low surrogate chars range from 0xDC00 to 0xDFFF.";
public const string XmlInvalidSurrogate = @"Surrogate char '0x{0}' not valid. Surrogate chars range from 0x10000 to 0x10FFFF.";

	}
}

namespace System.Runtime.Serialization
{
	static partial class SR {

public const string CombinedPrefixNSLength = @"The combined length of the prefix and namespace must not be greater than {0}.";
public const string InvalidInclusivePrefixListCollection = @"The inclusive namespace prefix collection cannot contain null as one of the items.";
public const string InvalidLocalNameEmpty = @"The empty string is not a valid local name.";
public const string XmlArrayTooSmall = @"Array too small.";
public const string XmlArrayTooSmallInput = @"Array too small.  Length of available data must be at least {0}.";
public const string XmlBadBOM = @"Unrecognized Byte Order Mark.";
public const string XmlBase64DataExpected = @"Base64 encoded data expected. Found {0}.";
public const string XmlCDATAInvalidAtTopLevel = @"CData elements not valid at top level of an XML document.";
public const string XmlCloseCData = @"']]>' not valid in text node content.";
public const string XmlConversionOverflow = @"The value '{0}' cannot be represented with the type '{1}'.";
public const string XmlDeclarationRequired = @"An XML declaration with an encoding is required for all non-UTF8 documents.";
public const string XmlDeclMissingVersion = @"Version not found in XML declaration.";
public const string XmlDeclMissing = @"An XML declaration is required for all non-UTF8 documents.";
public const string XmlDeclNotFirst = @"No characters can appear before the XML declaration.";
public const string XmlDictionaryStringIDRange = @"XmlDictionaryString IDs must be in the range from {0} to {1}.";
public const string XmlDictionaryStringIDUndefinedSession = @"XmlDictionaryString ID {0} not defined in the XmlBinaryReaderSession.";
public const string XmlDictionaryStringIDUndefinedStatic = @"XmlDictionaryString ID {0} not defined in the static dictionary.";
public const string XmlDuplicateAttribute = @"Duplicate attribute found. Both '{0}' and '{1}' are from the namespace '{2}'.";
public const string XmlEmptyNamespaceRequiresNullPrefix = @"The empty namespace requires a null or empty prefix.";
public const string XmlEncodingMismatch = @"The encoding in the declaration '{0}' does not match the encoding of the document '{1}'.";
public const string XmlEncodingNotSupported = @"XML encoding not supported.";
public const string XmlEndElementExpected = @"End element '{0}' from namespace '{1}' expected. Found {2}.";
public const string XmlEndElementNoOpenNodes = @"No corresponding start element is open.";
public const string XmlExpectedEncoding = @"The expected encoding '{0}' does not match the actual encoding '{1}'.";
public const string XmlFoundCData = @"cdata '{0}'";
public const string XmlFoundComment = @"comment '{0}'";
public const string XmlFoundElement = @"element '{0}' from namespace '{1}'";
public const string XmlFoundEndElement = @"end element '{0}' from namespace '{1}'";
public const string XmlFoundEndOfFile = @"end of file";
public const string XmlFoundNodeType = @"node {0}";
public const string XmlFoundText = @"text '{0}'";
public const string XmlFullStartElementExpected = @"Non-empty start element expected. Found {0}.";
public const string XmlFullStartElementLocalNameNsExpected = @"Non-empty start element '{0}' from namespace '{1}' expected. Found {2}.";
public const string XmlFullStartElementNameExpected = @"Non-empty start element '{0}' expected. Found {1}.";
public const string XmlIDDefined = @"ID already defined.";
public const string XmlKeyAlreadyExists = @"The specified key already exists in the dictionary.";
public const string XmlIllegalOutsideRoot = @"Text cannot be written outside the root element.";
public const string XmlInvalidBytes = @"Invalid byte encoding.";
public const string XmlInvalidCharRef = @"Character reference not valid.";
public const string XmlInvalidCommentChars = @"XML comments cannot contain '--' or end with '-'.";
public const string XmlInvalidDeclaration = @"XML declaration can only be written at the beginning of the document.";
public const string XmlInvalidDepth = @"Cannot call '{0}' while Depth is '{1}'.";
public const string XmlInvalidEncoding = @"XML encoding must be 'UTF-8'.";
public const string XmlInvalidFFFE = @"Characters with hexadecimal values 0xFFFE and 0xFFFF are not valid.";
public const string XmlInvalidFormat = @"The input source is not correctly formatted.";
public const string XmlInvalidID = @"ID must be >= 0.";
public const string XmlInvalidOperation = @"The reader cannot be advanced.";
public const string XmlInvalidPrefixState = @"A prefix cannot be defined while WriteState is '{0}'.";
public const string XmlInvalidQualifiedName = @"Expected XML qualified name. Found '{0}'.";
public const string XmlInvalidRootData = @"The data at the root level is invalid.";
public const string XmlInvalidStandalone = @"'standalone' value in declaration must be 'yes' or 'no'.";
public const string XmlInvalidStream = @"Stream returned by IStreamProvider cannot be null.";
public const string XmlInvalidUniqueId = @"UniqueId cannot be zero length.";
public const string XmlInvalidUTF8Bytes = @"'{0}' contains invalid UTF8 bytes.";
public const string XmlInvalidVersion = @"XML version must be '1.0'.";
public const string XmlInvalidWriteState = @"'{0}' cannot be called while WriteState is '{1}'.";
public const string XmlInvalidXmlByte = @"The byte 0x{0} is not valid at this location.";
public const string XmlInvalidXmlSpace = @"'{0}' is not a valid xml:space value. Valid values are 'default' and 'preserve'.";
public const string XmlLineInfo = @"Line {0}, position {1}.";
public const string XmlMalformedDecl = @"Malformed XML declaration.";
public const string XmlMaxArrayLengthExceeded = @"The maximum array length quota ({0}) has been exceeded while reading XML data. This quota may be increased by changing the MaxArrayLength property on the XmlDictionaryReaderQuotas object used when creating the XML reader.";


public const string XmlMaxNameTableCharCountExceeded = @"The maximum nametable character count quota ({0}) has been exceeded while reading XML data. The nametable is a data structure used to store strings encountered during XML processing - long XML documents with non-repeating element names, attribute names and attribute values may trigger this quota. This quota may be increased by changing the MaxNameTableCharCount property on the XmlDictionaryReaderQuotas object used when creating the XML reader.";

public const string XmlMethodNotSupported = @"This XmlWriter implementation does not support the '{0}' method.";
public const string XmlMissingLowSurrogate = @"The surrogate pair is invalid. Missing a low surrogate character.";
public const string XmlMultipleRootElements = @"There are multiple root elements.";
public const string XmlNamespaceNotFound = @"The namespace '{0}' is not defined.";
public const string XmlNestedArraysNotSupported = @"Nested arrays are not supported.";
public const string XmlNoRootElement = @"The document does not have a root element.";
public const string XmlOnlyOneRoot = @"Only one root element is permitted per document.";
public const string XmlOnlyWhitespace = @"Only white space characters can be written with this method.";
public const string XmlOnlySingleValue = @"Only a single typed value may be written inside an attribute or content.";
public const string XmlPrefixBoundToNamespace = @"The prefix '{0}' is bound to the namespace '{1}' and cannot be changed to '{2}'.";
public const string XmlProcessingInstructionNotSupported = @"Processing instructions (other than the XML declaration) and DTDs are not supported.";
public const string XmlReservedPrefix = @"Prefixes beginning with ""xml"" (regardless of casing) are reserved for use by XML.";
public const string XmlSpaceBetweenAttributes = @"Whitespace must appear between attributes.";
public const string XmlSpecificBindingNamespace = @"The namespace '{1}' can only be bound to the prefix '{0}'.";
public const string XmlSpecificBindingPrefix = @"The prefix '{0}' can only be bound to the namespace '{1}'.";
public const string XmlStartElementLocalNameNsExpected = @"Start element '{0}' from namespace '{1}' expected. Found {2}.";
public const string XmlStartElementNameExpected = @"Start element '{0}' expected. Found {1}.";
public const string XmlTagMismatch = @"Start element '{0}' does not match end element '{1}'.";
public const string XmlTokenExpected = @"The token '{0}' was expected but found '{1}'.";
public const string XmlUndefinedPrefix = @"The prefix '{0}' is not defined.";
public const string XmlUnexpectedEndElement = @"No matching start tag for end element.";
public const string XmlUnexpectedEndOfFile = @"Unexpected end of file. Following elements are not closed: {0}.";
public const string XmlWriterClosed = @"The XmlWriter is closed.";
public const string Xml_InvalidNmToken = @"Invalid NmToken value '{0}'.";

	}
}

#endregion
