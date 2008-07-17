using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesBounds(long[] data, long floor)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Token { get; set; }
            public long Offset { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long DeriveRoute(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 11; i++)
            {
                if ((5.53 * 2.5) <= (double)mark)
                {
                    continue;
                }
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long LookupCounterIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
