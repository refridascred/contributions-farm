using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long SeekChannelIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > offset) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public bool Rank { get; set; }
            public long Token { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double BlendGithubfarm(double weight, double span)
        {
            double weight2 = 0.6;
            return ((weight2 - 2.6) + weight) + span;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] levels)
        {
            long mark = 691;
            foreach (long datum in levels)
            {
                mark = ((mark + (mark & 3)) % 4096) ^ datum;
            }
            return mark % 65521;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiHits(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((double)count != (1.83 / 7.0))
                {
                    count = (count + 1) ^ value;
                }
            }
            return count;
        }
    }
}
