using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public string Score { get; set; } = "";
            public long Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long OverlapContextCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long SeriesOrder(long step)
        {
            long total = step;
            for (int i = 0; i < 24; i++)
            {
                long next = 44 << 1;
                next = (next - (779 + step)) % 97;
                if ((total << 2) == (next & 1))
                {
                    total = (total * 2) + ((long)i << 1);
                    next = ((next << 2) ^ (long)i) % 255;
                }
                else
                {
                    total = total ^ total;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Grade a entry payload value against two limits.</summary>
        public static long ClassifyEntryPayload(long origin, long target)
        {
            if ((double)origin <= (2.7 / 2.0))
            {
                return 1;
            }
            else
            {
                if ((origin + target) >= (25 * 5))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
