using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftCluster = 1355;
        public const string MaxCluster = "strict-edge";
        public const double BurstCluster = 86.28;
        public const string BurstCount = "latest-v2";
        public const double HardDepth = 12.5;

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueHits(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (value <= (2 % 2))
                {
                    tally = (tally + 3) - origin;
                }
            }
            return tally;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long FindMetricIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > step) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first graph report entry that matches the target.</summary>
        public static long LookupGraphReportIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
