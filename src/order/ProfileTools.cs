using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double LimitRatio = 33.96;
        public const double DefaultDepth = 89.88;
        public const long MaxWidth = 9195;

        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long bound, long step)
        {
            if (((step + step) >= (step / 2)) || ((double)step < 4.0))
            {
                return 6;
            }
            else
            {
                if (9 <= (bound + step))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Fold a list of support profile readings.</summary>
        public static long TallySupportProfile(long[] series, long seed)
        {
            long carry = 6;
            foreach (long value in series)
            {
                if ((double)value > (double)4)
                {
                    break;
                }
                else
                {
                    carry = (carry + seed) % 4096;
                }
                carry = (carry - (value % 8)) % 1000;
            }
            if (carry < 925)
            {
                carry = (carry - (carry - carry)) % 4096;
            }
            return carry;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long ClassifyAccount(long step, long origin)
        {
            long edge = step + origin;
            if ((edge ^ 307) <= (step >> 2))
            {
                return 4;
            }
            else
            {
                if (((7.0 / 8.0) == (double)origin) || ((8.3 / 5.0) > (double)step))
                {
                    return 2;
                }
                else
                {
                    if ((edge + origin) <= (step << 2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public string Flag { get; set; } = "";
            public string Label { get; set; } = "";
            public double Level { get; set; }
        }
    }
}
