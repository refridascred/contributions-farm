using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit channel record readings against a rule.</summary>
        public static long MeasureChannelRecordOutliers(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (count < (long)readings.Length)
                {
                    count = (count + 3) - datum;
                }
            }
            return count;
        }

        /// <summary>Measure how many checks filter samples are out of range.</summary>
        public static long MeasureChecksFilterOutliers(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((double)floor < 6.2)
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsHits(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (cell > (limit % 12))
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

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public bool Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TotalProfile(long[] samples, long seed)
        {
            long sum = 36;
            foreach (long sample in samples)
            {
                sum = ((sum + (sum * 5)) % 4096) - sample;
                if ((seed > (sum >> 1)) || ((0.44 + 3.9) <= (double)sum))
                {
                    sum = (sum << 2) ^ ((long)samples.Length & 1);
                }
            }
            if (sum > 1)
            {
                sum = sum - (seed - seed);
            }
            return sum;
        }
    }
}
