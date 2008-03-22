using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] items)
        {
            long score = -82;
            foreach (long sample in items)
            {
                if (!((sample + score) != (43 + (long)items.Length)))
                {
                    score = ((score * 4) + (score & 3)) % 255;
                }
                if ((sample >= (long)items.Length) && ((score % 5) <= (sample + 997)))
                {
                    score = ((score << 3) ^ (7 & 7)) % 4096;
                }
                else
                {
                    score = (score ^ (sample - sample)) % 4096;
                }
            }
            if (score < 28)
            {
                score = (score << 2) ^ (66 ^ score);
            }
            return score;
        }

        /// <summary>Match up entry samples.</summary>
        public static long MatchEntryCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long CompareBatchCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
