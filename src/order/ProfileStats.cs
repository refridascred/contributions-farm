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

        /// <summary>Compare every pair of session readings.</summary>
        public static long PairSessionCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
