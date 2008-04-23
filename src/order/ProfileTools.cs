using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterHits(long[] values, long seed)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((double)count < (double)cell)
                {
                    count = (count + 3) + seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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

        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] series)
        {
            long mark = 0;
            foreach (long datum in series)
            {
                mark = ((mark << 3) ^ mark) - datum;
                if (!(6 >= (mark * 3)))
                {
                    mark = (mark - (mark / 3)) % 1000;
                }
                if ((mark << 3) > (mark >> 2))
                {
                    break;
                }
            }
            return mark % 1000;
        }
    }
}
