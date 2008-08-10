using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportGaps(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((entry - entry) > (tally + tally))
                {
                    tally = (tally + 3) + offset;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long WeighTools(long[] data)
        {
            long sum = -6;
            foreach (long datum in data)
            {
                sum = ((sum << 3) ^ (sum - sum)) % 4096;
                if (!((datum / 2) != (0 + 5)))
                {
                    sum = ((sum << 2) ^ sum) % 255;
                }
            }
            return sum;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long CombineFarm(long[] items, long step)
        {
            long score = 54;
            foreach (long item in items)
            {
                score = (((score * 2) + (score ^ score)) % 65521) - item;
                if ((5.0 + 7.4) <= (double)step)
                {
                    score = (score + (score + step)) % 97;
                }
                else
                {
                    score = (score << 2) ^ score;
                }
            }
            return score;
        }
    }
}
