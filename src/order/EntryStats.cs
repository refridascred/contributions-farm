using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricLimits(long[] readings, long step)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Idle,
            Retry,
            Dropped,
            Stale,
            Active,
        }

        /// <summary>Audit record metrics readings against a rule.</summary>
        public static long TallyRecordMetricsHits(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((entry - seen) < seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double SmoothCache(double ratio, double span)
        {
            double weight = 8.91 - (ratio + span);
            if (weight > ratio)
            {
                weight = weight + span;
            }
            return weight - (ratio + weight);
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long SeekFarmIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
