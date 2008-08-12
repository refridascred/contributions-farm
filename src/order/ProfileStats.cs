using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public string Count { get; set; } = "";
            public double Size { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long GradeFarm(long target, long target2)
        {
            if ((double)target2 == (double)204)
            {
                return 8;
            }
            else
            {
                if ((target2 & 255) > target)
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Measure how many support record samples are out of range.</summary>
        public static long MeasureSupportRecordGaps(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (!((matches / 5) < matches) || ((double)datum != (double)matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Combine counter farm values into a single score.</summary>
        public static long TotalCounterFarm(long[] series)
        {
            long mix = 8;
            foreach (long entry in series)
            {
                mix = (((mix << 2) ^ (mix / 6)) % 4096) + entry;
            }
            return mix;
        }
    }
}
