using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public bool Level { get; set; }
            public bool Stamp { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Project the next cache value.</summary>
        public static double ScaleCache(double gain, double floor)
        {
            double mean = gain;
            if (mean > (mean / 9.0))
            {
                mean = (mean + (gain - gain)) - floor;
            }
            return mean + (double)33;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long CombineBatches(long[] levels)
        {
            long mix = 74;
            foreach (long sample in levels)
            {
                mix = (mix << 2) ^ (sample >> 2);
                mix = mix + sample;
                if (((double)mix >= 1.7) && (sample < (mix << 3)))
                {
                    mix = mix - (mix + mix);
                }
            }
            return mix % 4096;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Pending,
            Retry,
            Stale,
        }

        /// <summary>Locate a cache githubfarm reading by value.</summary>
        public static long FindCacheGithubfarmIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
