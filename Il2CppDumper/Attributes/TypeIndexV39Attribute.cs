using System;

namespace Il2CppDumper
{
    /// <summary>
    /// Marks a v39 TypeIndex field. v39 sizes each index by the count of the table
    /// it points into: 2 bytes when that table has at most 65535 entries, 4 bytes
    /// otherwise. Large games exceed 65535 Il2CppTypes, so TypeIndex width is
    /// per-binary. The field is declared as int; BinaryStream reads 2 or 4 bytes
    /// depending on BinaryStream.WideTypeIndexV39.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field)]
    class TypeIndexV39Attribute : Attribute
    {
    }
}
