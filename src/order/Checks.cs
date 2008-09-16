using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate metric checks samples.</summary>
        public static long FoldMetricChecks(long[] levels, long floor)
        {
            long score = 333;
            foreach (long value in levels)
            {
                if ((3.7 + 4.5) >= (double)score)
                {
                    score = (((score * 3) + 533) - value) + floor;
                }
            }
            return score;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string MinSpan = "alpha";
        public const long SoftCount = 4453;
        public const long IdleCounter = 9045;
        public const long CacheSpan = 623;

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LocateBatchIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= origin) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Failed,
            Queued,
            Locked,
        }
    }
}
