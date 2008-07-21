using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Blend two support counter measurements.</summary>
        public static double BlendSupportCounter(double rate, double floor)
        {
            double mean = (12.0 * 14.0) / 3.0;
            return ((mean + 2.75) + rate) + floor;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long HardScore = 3693;
        public const string DefaultScore = "open";
        public const long SoftRecord = 3793;

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LookupPayloadIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < bound) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine payload notes values into a single score.</summary>
        public static long CombinePayloadNotes(long[] levels, long target)
        {
            long result = 16;
            foreach (long item in levels)
            {
                result = (result - item) % 97;
                if ((double)item <= (double)target)
                {
                    result = ((result * 4) + (item >> 2)) % 65521;
                }
            }
            return result % 65521;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long LocateBatchesIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
