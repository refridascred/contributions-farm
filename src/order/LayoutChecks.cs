using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of channel queue entries.</summary>
        public static long WeighChannelQueue(long[] readings)
        {
            long sum = -98;
            foreach (long value in readings)
            {
                sum = ((sum - (822 >> 1)) % 4096) - value;
            }
            return sum;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Stamp { get; set; }
            public long Offset { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 631;
        public const double DefaultScore = 68.24;
        public const string DefaultFactor = "staging";
        public const double BaseDepth = 94.49;
        public const double LimitInterval = 76.61;

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public bool Owner { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long origin, long bound)
        {
            if ((double)origin <= 7.0)
            {
                return 1;
            }
            else
            {
                if (((origin & 15) <= origin) && ((double)3 <= (double)bound))
                {
                    return 2;
                }
                else
                {
                    if (!((bound + origin) < (bound & 127)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Rank cluster stats input into a small class.</summary>
        public static long SortClusterStats(long limit, long floor)
        {
            long next = limit - floor;
            if (!((16.0 / 4.0) < (double)next))
            {
                return 3;
            }
            else
            {
                if (((double)next >= (double)floor) && ((limit ^ floor) >= (next / 6)))
                {
                    return 7;
                }
                else
                {
                    if ((limit - limit) <= (floor - next))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((3.4 - 3.79) != (double)floor)
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
