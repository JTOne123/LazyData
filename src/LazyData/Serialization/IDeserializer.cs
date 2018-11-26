using System;

namespace LazyData.Serialization
{
    public interface IDeserializer
    {
        object Deserialize(Type type, DataObject data);
        T Deserialize<T>(DataObject data) where T : new();

        void DeserializeInto(DataObject data, object existingInstance);
        void DeserializeInto<T>(DataObject data, T existingInstance);
    }
}