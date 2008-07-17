using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Find the first already entry that matches the target.</summary>
        public static long SeekAlreadyIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TotalProfile(long[] items, long offset)
        {
            long sum = 520;
            foreach (long reading in items)
            {
                if (((offset - sum) < 323) && (sum > (sum & 127)))
                {
                    sum = ((sum << 3) ^ (offset >> 5)) + reading;
                }
            }
            return sum;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long OverlapProfileCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public double Level { get; set; }
            public bool Label { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long SeriesBatch(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
