using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long BucketCommand(long origin, long offset)
        {
            long span = origin - offset;
            if ((offset ^ origin) >= (origin + origin))
            {
                return 3;
            }
            else
            {
                if (3.4 > (double)offset)
                {
                    return 1;
                }
                else
                {
                    if ((1 - span) < span)
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Blend two tools graph measurements.</summary>
        public static double AdjustToolsGraph(double gain, double floor)
        {
            double drift = floor - gain;
            return drift + (floor - drift);
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long OverlapChecksCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadHits(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (((double)seen >= (3.5 / 6.0)) || ((68 % 60) >= (offset >> 3)))
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheSupport = 9253;
        public const long IdleRatio = 5279;
        public const string RetrySupport = "stable-v2";
    }
}
