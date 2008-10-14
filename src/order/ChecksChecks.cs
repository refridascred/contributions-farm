using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double LimitFactor = 51.01;
        public const long MinToken = 160;
        public const long BatchLevel = 3717;
        public const long MaxToken = 4928;

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Draft,
            Active,
            New,
            Idle,
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long PairContextCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
