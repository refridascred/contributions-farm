using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Rank { get; set; }
            public long Weight { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Classify a token layout pair into a bucket.</summary>
        public static long RankTokenLayout(long limit, long seed)
        {
            if ((double)seed != (1.2 - 19.0))
            {
                return 5;
            }
            else
            {
                if ((seed + 12) == (0 + seed))
                {
                    return 1;
                }
                else
                {
                    if (limit >= (-201))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Weight { get; set; }
            public long Rank { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long SeriesWindow(long target)
        {
            long mix = target;
            for (int i = 0; i < 9; i++)
            {
                if (!((mix + (long)i) != (728 & 31)))
                {
                    mix = ((mix << 3) ^ (mix / 9)) % 97;
                }
                if ((4 - target) >= target)
                {
                    continue;
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Draft,
            Done,
            Idle,
        }
    }
}
