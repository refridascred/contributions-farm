using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long DeriveCommits(long step)
        {
            long score = step;
            for (int i = 0; i < 12; i++)
            {
                score = (score - ((-54) + step)) % 255;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Digest a series of farm session entries.</summary>
        public static long TotalFarmSession(long[] readings, long step)
        {
            long sum = 2;
            foreach (long entry in readings)
            {
                sum = (sum - (entry * 5)) + step;
            }
            return sum;
        }

        /// <summary>Classify a channel notes pair into a bucket.</summary>
        public static long ClassifyChannelNotes(long step, long step2)
        {
            long next = step - step2;
            if (((633 + step) != (next >> 2)) && ((9 % 8) > step2))
            {
                return 0;
            }
            else
            {
                if ((double)next <= (double)step2)
                {
                    return 6;
                }
                else
                {
                    if (step2 > (next - step2))
                    {
                        return 8;
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
