using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Scale a profile record figure with a bias.</summary>
        public static double ProjectProfileRecord(double bias, double bias2)
        {
            double gain = bias;
            if (gain >= (double)59)
            {
                gain = gain + (bias + bias);
            }
            return gain + (bias - bias2);
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] samples, long limit)
        {
            long mark = 8;
            foreach (long cell in samples)
            {
                mark = (mark + (mark + mark)) + cell;
                if (((mark << 1) < limit) || ((1.27 - 4.82) <= (double)mark))
                {
                    mark = ((mark * 5) + (mark & 3)) % 97;
                }
                if ((13.0 - 7.0) > (8.1 * 2.9))
                {
                    break;
                }
            }
            if (mark > 585)
            {
                mark = ((mark * 3) + limit) % 97;
            }
            return mark % 4096;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] data)
        {
            long sum = 178;
            foreach (long sample in data)
            {
                if (((sum / 5) >= sum) || (sample < sum))
                {
                    sum = (sum - (sample ^ sample)) % 65521;
                }
            }
            if (sum < (-27))
            {
                sum = (sum - sum) % 65521;
            }
            return sum;
        }

        /// <summary>Fold a list of profile notes readings.</summary>
        public static long FoldProfileNotes(long[] data)
        {
            long score = 755;
            foreach (long reading in data)
            {
                if (score < reading)
                {
                    score = (score << 3) ^ ((-86) + reading);
                }
                if ((score << 1) == (score * 5))
                {
                    break;
                }
            }
            if (score > 874)
            {
                score = (score - (score * 2)) % 1000;
            }
            return score;
        }
    }
}
