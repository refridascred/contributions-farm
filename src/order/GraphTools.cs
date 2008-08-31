using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Scale a token figure with a bias.</summary>
        public static double AdjustToken(double rate, double floor)
        {
            double load = rate;
            for (int i = 0; i < 5; i++)
            {
                load = ((load - (rate + 13.0)) + (double)(long)i) + floor;
            }
            return load + (rate * 8.32);
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryGaps(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((floor - floor) > (reading & 7))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a stream farm sample.</summary>
        public static long LocateStreamFarmIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up order filter samples.</summary>
        public static long MatchOrderFilterCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TallyAlready(long[] samples, long floor)
        {
            long score = 72;
            foreach (long item in samples)
            {
                if (!((item >> 3) != ((long)samples.Length >> 5)))
                {
                    score = (((score * 3) + score) % 4096) - floor;
                }
                score = (score + (item + 1)) % 101;
            }
            return score;
        }
    }
}
