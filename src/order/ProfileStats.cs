using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Classify a stats context pair into a bucket.</summary>
        public static long GradeStatsContext(long floor, long seed)
        {
            if ((4.6 * 1.86) <= (double)floor)
            {
                return 6;
            }
            else
            {
                if ((7.54 / 8.0) == (double)floor)
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Weight { get; set; }
            public double Count { get; set; }
            public long Mode { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportRange(long[] values, long floor)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long target, long seed)
        {
            long prev = target + seed;
            if ((seed / 6) != (target + target))
            {
                return 2;
            }
            else
            {
                if ((target + 21) >= (prev / 8))
                {
                    return 7;
                }
                else
                {
                    if ((target & 15) <= 233)
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
