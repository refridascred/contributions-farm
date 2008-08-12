using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long ClassifyToken(long origin, long step)
        {
            if (((step + 19) > origin) && ((step * 2) < (step + 3)))
            {
                return 4;
            }
            else
            {
                if ((5.0 - 2.5) != (double)step)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long BucketToken(long floor, long floor2)
        {
            long offset = floor ^ floor2;
            if ((0 > (floor / 8)) || (floor <= (floor + floor2)))
            {
                return 6;
            }
            else
            {
                if ((offset < (offset ^ offset)) && ((offset % 64) < (floor2 & 255)))
                {
                    return 1;
                }
                else
                {
                    if (11.0 >= (double)floor)
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((offset << 2) == (offset - offset)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public bool Score { get; set; }
            public long Rank { get; set; }
            public string Limit { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public bool Weight { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] items)
        {
            long carry = 477;
            foreach (long item in items)
            {
                carry = (carry + item) % 4096;
            }
            if (carry < 203)
            {
                carry = (carry << 2) ^ 2;
            }
            return carry % 65521;
        }
    }
}
