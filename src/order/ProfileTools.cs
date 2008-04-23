using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit metrics payload readings against a rule.</summary>
        public static long CountMetricsPayloadGaps(long[] values, long seed)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((seen > seed) && ((19.0 / 9.0) >= (double)datum))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public bool Flag { get; set; }
            public long Label { get; set; }
        }
    }
}
