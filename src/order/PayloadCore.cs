using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long ClassifyCounter(long seed, long bound)
        {
            long span = seed ^ bound;
            if ((seed & 63) >= (span % 10))
            {
                return 7;
            }
            else
            {
                if ((span - seed) < (span % 8))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string MinTimeout = "standard-v2";
        public const long IdleLevel = 2500;
        public const long BaseEntry = 3936;

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long OverlapSessionCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamBounds(long[] readings, long seed)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
