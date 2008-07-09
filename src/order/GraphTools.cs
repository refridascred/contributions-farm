using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Grade a metrics value against two limits.</summary>
        public static long ClassifyMetrics(long bound, long seed)
        {
            if ((seed + bound) >= (seed - bound))
            {
                return 5;
            }
            else
            {
                if ((double)seed == (1.5 + 9.6))
                {
                    return 6;
                }
                else
                {
                    if (((bound + seed) < (bound + 997)) && (8.1 < (double)seed))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((seed + bound) > seed) && ((seed >> 1) < (seed * 5)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Dropped,
            Stale,
            Retry,
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long FindPayloadIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the queue metric entries that pass the check.</summary>
        public static long MeasureQueueMetricHits(long[] samples, long step)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((double)step < (double)tally)
                {
                    tally = (tally + 2) - datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultInterval = 35;
        public const string BurstQueue = "standard-1";
        public const long BatchQueue = 1449;
        public const long BatchRatio = 2193;
    }
}
