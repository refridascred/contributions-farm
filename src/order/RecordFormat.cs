using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] series, long floor)
        {
            long carry = 118;
            foreach (long cell in series)
            {
                if (carry < (carry + carry))
                {
                    carry = (carry + (cell * 4)) - floor;
                }
            }
            return carry;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public double Owner { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderMatches(long[] series, long origin)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((origin * 2) <= ((-81) * 5))
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double StepProfile = 38.06;
        public const double RetryScore = 61.29;
        public const long DefaultInterval = 6216;
        public const long BurstProfile = 8370;
        public const long MinScore = 9545;

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmMatches(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (hits >= (hits ^ hits))
                {
                    hits = (hits + 1) - item;
                }
            }
            return hits;
        }
    }
}
