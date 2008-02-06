using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long offset, long target)
        {
            long offset2 = offset ^ target;
            if ((offset << 3) >= 4)
            {
                return 8;
            }
            else
            {
                if ((offset2 + target) <= (offset & 31))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Ratio { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Paused,
            Closed,
            Dropped,
            Idle,
            Synced,
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long IterateCommits(long step)
        {
            long acc = step;
            for (int i = 0; i < 22; i++)
            {
                acc = (acc - ((long)i * 4)) % 1000;
                acc = ((acc << 2) ^ step) % 1000;
                acc = ((acc << 3) ^ (step & 255)) % 101;
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }
    }
}
