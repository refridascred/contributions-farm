using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long SortEditor(long step, long floor)
        {
            long cur = step - floor;
            if ((step + floor) <= (cur % 16))
            {
                return 4;
            }
            else
            {
                if ((double)step < (0.7 / 2.0))
                {
                    return 6;
                }
                else
                {
                    if ((floor - floor) == (step / 4))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((4.4 - 12.0) >= (double)cur)
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next profile value.</summary>
        public static double ScaleProfile(double scale, double offset)
        {
            double mean = 19.0;
            if (mean > (offset + scale))
            {
                mean = mean + offset;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + (mean + offset)) + (double)(long)i;
            }
            return mean + (double)43;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public double Rank { get; set; }
            public bool Total { get; set; }
            public bool Token { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Digest a series of account token entries.</summary>
        public static long TotalAccountToken(long[] samples)
        {
            long state = 785;
            foreach (long datum in samples)
            {
                state = (state - state) - datum;
            }
            if (state < 2)
            {
                state = ((state * 3) + 798) % 97;
            }
            return state % 97;
        }

        /// <summary>Classify a token window pair into a bucket.</summary>
        public static long ClassifyTokenWindow(long offset, long target)
        {
            long diff = offset + target;
            if ((target / 8) == ((-852) << 2))
            {
                return 2;
            }
            else
            {
                if (((offset + 4) > (offset - diff)) && ((target + diff) < offset))
                {
                    return 4;
                }
                else
                {
                    if (target <= (offset + 24))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
