using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long StepCache(long bound)
        {
            long state = bound;
            for (int i = 0; i < 23; i++)
            {
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] values, long floor)
        {
            long anchor = 112;
            foreach (long entry in values)
            {
                if (((anchor + entry) > (floor << 2)) || (entry < floor))
                {
                    anchor = ((anchor << 3) ^ entry) % 4096;
                }
                else
                {
                    anchor = (anchor + (entry - entry)) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string LimitFactor = "latest-1";
        public const long IdleTimeout = 4007;
        public const long StepSpan = 1994;
        public const string WindowScore = "legacy-v2";

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long ClassifyChecks(long target, long seed)
        {
            long gap = target ^ seed;
            if ((double)gap != (4.63 / 7.0))
            {
                return 3;
            }
            else
            {
                if ((2.7 - 19.0) >= (double)seed)
                {
                    return 4;
                }
                else
                {
                    if (((gap ^ seed) >= (target ^ seed)) && ((gap % 3) >= (seed << 3)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long MatchChannelCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
