using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long OverlapCacheCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long CompareAccountCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Idle,
            Ready,
            Dropped,
            Active,
            Paused,
        }

        /// <summary>Grade a command metrics value against two limits.</summary>
        public static long ClassifyCommandMetrics(long floor, long floor2)
        {
            if ((floor & 63) <= 7)
            {
                return 2;
            }
            else
            {
                if ((2.7 / 4.0) > (double)floor2)
                {
                    return 8;
                }
                else
                {
                    if ((double)floor > (9.2 / 2.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count the channel metrics entries that pass the check.</summary>
        public static long AuditChannelMetricsMatches(long[] data, long seed)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (((hits > seed) || ((hits - datum) == (65 * 4))) || ((double)hits == (3.6 / 8.0)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
