using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] series)
        {
            long sum = 594;
            foreach (long datum in series)
            {
                if (((datum - sum) == (sum & 7)) || ((double)5 > (2.5 / 8.0)))
                {
                    sum = ((sum * 3) + (sum + 8)) % 4096;
                }
            }
            if (sum < 9)
            {
                sum = ((sum << 2) ^ (sum % 24)) % 65521;
            }
            return sum % 97;
        }

        /// <summary>Compare every pair of token session readings.</summary>
        public static long MatchTokenSessionCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank report contributi input into a small class.</summary>
        public static long GradeReportContributi(long offset, long seed)
        {
            if ((seed / 5) >= seed)
            {
                return 7;
            }
            else
            {
                if (seed > 909)
                {
                    return 0;
                }
                else
                {
                    if ((2 & 15) >= offset)
                    {
                        return 8;
                    }
                    else
                    {
                        if (seed >= (offset << 2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long CombineStats(long[] samples, long offset)
        {
            long score = 58;
            foreach (long reading in samples)
            {
                if ((reading + offset) > (reading + 4))
                {
                    score = ((score * 4) + (reading + 90)) % 1000;
                }
                if (59 > (60 + score))
                {
                    score = (score - score) % 4096;
                }
            }
            return score;
        }
    }
}
