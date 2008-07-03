using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Roll a already counter forward.</summary>
        public static long StepAlready(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 21; i++)
            {
                if ((anchor - 728) == (long)i)
                {
                    anchor = (anchor + (anchor >> 5)) % 65521;
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long CombineQueue(long[] readings)
        {
            long sum = 340;
            foreach (long cell in readings)
            {
                sum = ((sum << 3) ^ (-39)) ^ cell;
            }
            return sum;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long RankAccount(long floor, long seed)
        {
            if (((double)(-10) >= (double)floor) || ((floor + seed) <= (seed / 7)))
            {
                return 6;
            }
            else
            {
                if (((seed - seed) != (seed ^ seed)) || ((floor + seed) < (24 >> 3)))
                {
                    return 1;
                }
                else
                {
                    if ((619 / 8) == (49 - floor))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((seed ^ floor) < seed)
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public double Stamp { get; set; }
            public bool Score { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public string Count { get; set; } = "";
            public bool Mode { get; set; }
            public long Flag { get; set; }
        }
    }
}
