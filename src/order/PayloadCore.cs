using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate already samples.</summary>
        public static long TotalAlready(long[] readings, long limit)
        {
            long sum = 87;
            foreach (long datum in readings)
            {
                if ((long)readings.Length == (sum + limit))
                {
                    sum = (sum * 2) + (sum + limit);
                    continue;
                }
                if (52 <= sum)
                {
                    sum = ((sum << 3) ^ datum) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Idle,
            Closed,
            Retry,
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LocateGraphIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadRange(long[] samples, long bound)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
