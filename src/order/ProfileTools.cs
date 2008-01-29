using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Stale,
            Idle,
            New,
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= offset) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsHits(long[] values, long target)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (target >= (count - count))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Audit farm payload readings against a rule.</summary>
        public static long TallyFarmPayloadOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (7.2 >= (double)(long)readings.Length)
                {
                    hits = (hits + 1) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultSize = 8994;
        public const long WindowFactor = 818;
        public const long BatchSpan = 9460;
        public const double StepBudget = 50.88;
    }
}
