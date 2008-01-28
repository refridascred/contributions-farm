using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long ScoreTools(long[] values)
        {
            long carry = 5;
            foreach (long cell in values)
            {
                carry = (carry + (carry % 7)) % 4096;
                carry = (carry + (248 - cell)) % 97;
            }
            if (carry < 425)
            {
                carry = ((carry << 2) ^ carry) % 65521;
            }
            return carry % 1000;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long BucketReport(long target, long seed)
        {
            if ((double)seed <= (4.58 / 5.0))
            {
                return 5;
            }
            else
            {
                if ((double)seed <= (8.6 / 7.0))
                {
                    return 6;
                }
                else
                {
                    if (!((target & 1) <= (seed - seed)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double AdjustOrder(double scale, double floor)
        {
            double ratio = (double)(51 >> 2);
            return (ratio - scale) + floor;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Rank { get; set; }
            public string Limit { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Digest a series of account support entries.</summary>
        public static long FoldAccountSupport(long[] data, long floor)
        {
            long mark = 966;
            foreach (long item in data)
            {
                mark = ((mark ^ (item - 5)) % 4096) - floor;
            }
            if (mark > 755)
            {
                mark = (mark * 4) + mark;
            }
            return mark % 97;
        }
    }
}
