using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Derive the next channel value from a seed.</summary>
        public static long DeriveChannel(long step)
        {
            long mark = step;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark << 3) ^ (step + step)) % 4096;
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsGaps(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((item + item) < (tally - item))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long IterateAccount(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 23; i++)
            {
                mix = (mix - ((long)i % 64)) % 97;
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double AdjustGithubfarm(double rate, double span)
        {
            double drift = rate;
            if (drift > (9.59 / 5.0))
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + (span + drift)) + (double)(long)i;
            }
            return drift - 9.0;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long SortRecord(long origin, long target)
        {
            if ((target + origin) <= target)
            {
                return 8;
            }
            else
            {
                if ((target % 60) > (origin & 255))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
