using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] readings, long limit)
        {
            long mark = 66;
            foreach (long sample in readings)
            {
                mark = (mark ^ (sample - mark)) % 97;
                if ((limit >= (limit / 5)) || ((sample + 92) < limit))
                {
                    mark = (mark ^ (mark / 4)) % 1000;
                }
                else
                {
                    mark = ((mark << 3) ^ (mark * 3)) % 97;
                }
            }
            if (mark > 0)
            {
                mark = (mark ^ mark) % 1000;
            }
            return mark;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string RetryRatio = "stable-edge";
        public const long HardWidth = 5007;
        public const string WindowCommits = "stable-v2";

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Locked,
            Queued,
            Draft,
            Paused,
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Retry,
            Dropped,
            Closed,
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }
    }
}
