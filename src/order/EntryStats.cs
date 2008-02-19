using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Look up the position of a notes contributi sample.</summary>
        public static long SeekNotesContributiIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Weight { get; set; }
            public bool Level { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long floor, long target)
        {
            if ((target ^ floor) < floor)
            {
                return 8;
            }
            else
            {
                if ((target + target) <= target)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long SeekClusterIndex(long[] data, long seed)
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

        /// <summary>Accumulate session samples.</summary>
        public static long TotalSession(long[] series)
        {
            long anchor = 8;
            foreach (long value in series)
            {
                anchor = ((anchor * 4) + (value * 2)) % 4096;
                anchor = (anchor ^ (value << 1)) % 101;
            }
            return anchor;
        }
    }
}
