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

        /// <summary>Grade a command value against two limits.</summary>
        public static long BucketCommand(long offset, long origin)
        {
            if (9.03 <= (double)origin)
            {
                return 0;
            }
            else
            {
                if ((double)offset <= (double)origin)
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Retry,
            Paused,
            Done,
            Dropped,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardCount = 630;
        public const long BatchBudget = 8182;
        public const string BurstCluster = "fallback-1";

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
