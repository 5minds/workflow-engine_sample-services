namespace App.SharedDataStore
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Concurrent;

    using Contracts;

    internal class SimpleInMemoryStore
    {
        internal static SimpleInMemoryStore Instance { get; } = new SimpleInMemoryStore();

        internal IList<DataStoreItem> Data { get; } = new List<DataStoreItem>();
    }
}
