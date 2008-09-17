using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the context series from a seed.</summary>
        public static long DeriveContext(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 22; i++)
            {
                acc = (acc ^ (floor >> 5)) % 4096;
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Closed,
            Failed,
            Idle,
            Pending,
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenHits(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((0 - seen) <= seen)
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }
    }
}
