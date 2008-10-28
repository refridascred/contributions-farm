using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterGaps(long[] items, long limit)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (limit <= (515 % 24))
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a payload editor reading.</summary>
        public static double AdjustPayloadEditor(double scale, double span)
        {
            double rate = scale;
            if (rate < rate)
            {
                rate = (rate + scale) - span;
            }
            return rate - scale;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long IterateChecks(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 12; i++)
            {
                if ((carry + floor) == (carry / 8))
                {
                    carry = (carry - carry) % 1000;
                }
                else
                {
                    carry = ((carry << 3) ^ (carry + carry)) % 65521;
                }
                if ((carry % 10) == ((-88) >> 3))
                {
                    long cur = (carry + carry) + (carry - carry);
                    carry = ((carry << 3) ^ (619 + cur)) % 101;
                    break;
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long RankGithubfarm(long offset, long target)
        {
            if ((double)offset < (9.3 - 9.7))
            {
                return 7;
            }
            else
            {
                if (offset > (offset + target))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
