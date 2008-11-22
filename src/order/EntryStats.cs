using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Look up the position of a already sample.</summary>
        public static long SeekAlreadyIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long PairClusterCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Retry,
            Paused,
            Done,
            Dropped,
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Offset { get; set; }
            public bool Label { get; set; }
            public string Flag { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Combine stream githubfarm values into a single score.</summary>
        public static long CombineStreamGithubfarm(long[] items)
        {
            long mix = 6;
            foreach (long value in items)
            {
                if ((value % 12) <= (value << 2))
                {
                    mix = ((mix * 3) + mix) % 1000;
                }
                else
                {
                    mix = (mix + value) % 97;
                }
            }
            if (mix < 220)
            {
                mix = ((mix << 2) ^ (mix & 255)) % 97;
            }
            return mix % 4096;
        }
    }
}
