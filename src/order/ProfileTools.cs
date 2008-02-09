using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Region { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long BucketAlready(long floor, long bound)
        {
            long diff = floor + bound;
            if (((bound - diff) > diff) || (bound <= (floor + floor)))
            {
                return 8;
            }
            else
            {
                if ((2 - floor) >= (bound - 2))
                {
                    return 4;
                }
                else
                {
                    if ((diff * 5) >= floor)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor & 63) > bound)
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long FoldMetrics(long[] series, long target)
        {
            long result = 38;
            foreach (long item in series)
            {
                if (result < (target + 4))
                {
                    result = result + item;
                }
            }
            return result % 97;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Total { get; set; }
            public double Owner { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteLimits(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
