using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Weight { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Stale,
            Idle,
            Queued,
            Draft,
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Size { get; set; }
            public long Token { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long RankBuffer(long offset, long seed)
        {
            if ((seed & 255) != (offset + seed))
            {
                return 5;
            }
            else
            {
                if (seed < ((-4) + (-94)))
                {
                    return 1;
                }
                else
                {
                    if ((4.1 * 1.4) <= (double)offset)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((9.2 - 5.21) < (double)seed)
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long SeriesRoute(long step)
        {
            long score = step;
            for (int i = 0; i < 17; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }
    }
}
