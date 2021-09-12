using System;
using System.Collections.Generic;

namespace Agamotto.Net.Abstractions
{
    public interface ICommodity
    {
        Guid IdempotencyKey { get; }
        string AggregateKey { get; }
        
        string HashCode { get; }
        IDictionary<string, object> Meta { get; }
    }

    public interface ICommodity<out TData> : ICommodity where TData : class
    {
        TData Data { get; }
    }
}