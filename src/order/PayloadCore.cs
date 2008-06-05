using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Scale a editor figure with a bias.</summary>
        public static double AdjustEditor(double scale, double bias)
        {
            double gain = (double)(50 ^ (-393));
            if (gain > (19.0 + gain))
            {
                gain = (gain + (3.97 * 2.76)) - scale;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + 6.7) + (double)(long)i;
            }
            return gain + (bias * 5.6);
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long DigestStats(long[] items)
        {
            long score = 91;
            foreach (long value in items)
            {
                if ((double)value == (4.67 - 0.96))
                {
                    score = ((score << 3) ^ score) % 97;
                }
                if ((value & 63) <= (score * 2))
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long RankGithubfarm(long origin, long target)
        {
            long diff = origin - target;
            if (target < diff)
            {
                return 5;
            }
            else
            {
                if (origin <= (origin + diff))
                {
                    return 7;
                }
                else
                {
                    if ((double)target <= (6.06 - 5.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if (origin >= (-475))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Retry,
            Active,
            New,
            Draft,
        }
    }
}
