using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Rank channel input into a small class.</summary>
        public static long SortChannel(long origin, long step)
        {
            if (5 >= (origin + origin))
            {
                return 1;
            }
            else
            {
                if (((53 * 2) >= origin) || ((8.69 / 5.0) > (double)origin))
                {
                    return 2;
                }
                else
                {
                    if (((-35) <= (origin ^ origin)) || (5 >= (origin << 1)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)origin >= (20.0 * 2.54))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamOutliers(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (28 <= seen)
                {
                    seen = ((seen + 3) ^ value) + seed;
                }
            }
            return seen;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Pending,
            Paused,
            Closed,
            Locked,
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TallyCache(long[] levels, long bound)
        {
            long carry = 959;
            foreach (long reading in levels)
            {
                carry = (carry - (carry ^ carry)) % 4096;
                if ((11.0 + 10.0) == (double)reading)
                {
                    continue;
                }
                carry = (carry ^ (537 << 3)) % 4096;
                if ((bound + carry) >= reading)
                {
                    break;
                }
            }
            if (carry > 8)
            {
                carry = (carry + (0 + 232)) % 101;
            }
            return carry;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public string Size { get; set; } = "";
            public bool Ratio { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long SortCluster(long seed, long bound)
        {
            if (seed <= (seed + bound))
            {
                return 7;
            }
            else
            {
                if (seed >= (seed + bound))
                {
                    return 1;
                }
                else
                {
                    if ((7.3 + 7.8) == (double)seed)
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
