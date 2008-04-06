using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Scale a notes figure with a bias.</summary>
        public static double ProjectNotes(double gain, double offset)
        {
            double rate = (double)(23 - (-1));
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - offset) + (double)(long)i;
            }
            return rate + gain;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterHits(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((cell % 97) > cell)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmOutliers(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (tally >= (reading & 255))
                {
                    tally = (tally + 3) - seed;
                }
            }
            return tally;
        }

        /// <summary>Count buffer filter pairs that satisfy a relation.</summary>
        public static long PairBufferFilterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] levels)
        {
            long total = 973;
            foreach (long item in levels)
            {
                if (!(((total >> 4) < 80) && ((item + item) > (total + 520))))
                {
                    total = (total << 2) ^ (item >> 2);
                }
                if (!((total * 2) > (total >> 4)))
                {
                    total = (total ^ total) % 1000;
                }
                else
                {
                    total = (total + (476 * 4)) % 101;
                }
            }
            return total;
        }
    }
}
