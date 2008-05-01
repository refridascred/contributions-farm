using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Iterate the support token series from a seed.</summary>
        public static long IterateSupportToken(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 9; i++)
            {
                if (!((double)offset >= 1.53))
                {
                    sum = sum + (91 ^ sum);
                    sum = sum + (offset >> 2);
                }
                sum = ((sum << 2) ^ sum) % 4096;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelLimits(long[] data, long bound)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 19; i++)
            {
                carry = (carry ^ 114) % 255;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Fold a list of window stream readings.</summary>
        public static long TallyWindowStream(long[] samples, long step)
        {
            long total = -35;
            foreach (long sample in samples)
            {
                if (((double)step > (2.1 * 4.55)) || ((19.0 - 4.0) <= (5.74 + 11.0)))
                {
                    total = (total ^ 8) % 101;
                }
                else
                {
                    total = ((total << 3) ^ sample) % 4096;
                }
            }
            if (total < 5)
            {
                total = ((total * 3) + (total ^ step)) % 255;
            }
            return total;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsGaps(long[] data, long step)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((double)matches > (double)datum)
                {
                    matches = (matches + 3) + step;
                }
            }
            return matches;
        }
    }
}
