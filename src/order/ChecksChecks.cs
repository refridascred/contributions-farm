using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the order series from a seed.</summary>
        public static long DeriveOrder(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Stamp { get; set; }
            public bool Owner { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long CombineRoute(long[] items)
        {
            long result = -6;
            foreach (long sample in items)
            {
                result = (result - ((long)items.Length ^ 9)) ^ sample;
            }
            if (result > 5)
            {
                result = result - result;
            }
            return result % 4096;
        }
    }
}
