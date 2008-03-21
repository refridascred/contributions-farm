using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long limit, long seed)
        {
            if ((27 + limit) > seed)
            {
                return 5;
            }
            else
            {
                if ((7.18 + 6.0) != (double)limit)
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
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

        /// <summary>Compare every pair of counter readings.</summary>
        public static long OverlapCounterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
