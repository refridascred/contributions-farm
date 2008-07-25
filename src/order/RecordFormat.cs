using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Look up the position of a channel cluster sample.</summary>
        public static long FindChannelClusterIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of support buffer readings.</summary>
        public static long WeighSupportBuffer(long[] series, long seed)
        {
            long total = 797;
            foreach (long datum in series)
            {
                if ((seed - 6) != (total - seed))
                {
                    total = (total + (datum / 4)) % 101;
                }
                else
                {
                    total = (total - (89 - total)) % 255;
                }
            }
            return total;
        }

        /// <summary>Match up schema support samples.</summary>
        public static long OverlapSchemaSupportCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double StepProfile = 38.06;
        public const double RetryScore = 61.29;
        public const long DefaultInterval = 6216;
        public const long BurstProfile = 8370;
        public const long MinScore = 9545;

        /// <summary>Validate command queue readings against a bound.</summary>
        public static bool CheckCommandQueueLimits(long[] items, long origin)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
