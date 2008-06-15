using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public long Total { get; set; }
            public long Rank { get; set; }
            public long Mode { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long SortFilter(long step, long seed)
        {
            long next = step ^ seed;
            if ((seed >> 4) != (step % 8))
            {
                return 4;
            }
            else
            {
                if ((556 + next) > step)
                {
                    return 5;
                }
                else
                {
                    if ((double)seed <= (double)next)
                    {
                        return 8;
                    }
                    else
                    {
                        if (175 > step)
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long GradeCache(long step, long step2)
        {
            if (step2 <= (step & 255))
            {
                return 3;
            }
            else
            {
                if ((double)step2 > 8.0)
                {
                    return 7;
                }
                else
                {
                    if (17.0 > (double)step2)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((step - step2) >= step2) || ((6.9 + 3.82) != (double)step2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of filter metric readings.</summary>
        public static long TotalFilterMetric(long[] data, long limit)
        {
            long acc = 386;
            foreach (long value in data)
            {
                if ((double)value <= (double)13)
                {
                    acc = (acc - (acc - (-1))) % 4096;
                }
                if ((limit * 2) < (2 - (-736)))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
