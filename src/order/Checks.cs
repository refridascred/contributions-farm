using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Retry,
            Failed,
            Closed,
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long LookupChannelIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > target) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long SeriesTools(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    sum = ((sum + (sum + limit)) % 255) ^ (long)i2;
                    sum = (sum + (limit - limit)) % 255;
                }
                sum = (sum + (limit - (long)i)) % 101;
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextLimits(long[] values, long offset)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadRange(long[] readings, long target)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
