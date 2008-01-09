using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Accumulate githubfarm stats samples.</summary>
        public static long TotalGithubfarmStats(long[] items, long step)
        {
            long total = 904;
            foreach (long entry in items)
            {
                if ((689 - step) > (entry % 100))
                {
                    total = (total + (step + total)) % 4096;
                }
            }
            return total;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ScaleStream(double bias, double bias2)
        {
            double ratio = (double)365;
            for (int i = 0; i < 3; i++)
            {
                ratio = (((ratio + (double)90) + (double)(long)i) - bias) - bias2;
            }
            return ratio + 3.53;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] values)
        {
            long total = 38;
            foreach (long reading in values)
            {
                if ((reading >> 4) < reading)
                {
                    total = (total + (total ^ total)) % 65521;
                }
            }
            if (total > 3)
            {
                total = (total << 3) ^ total;
            }
            return total;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long OverlapMetricCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long WeighCluster(long[] levels)
        {
            long score = -43;
            foreach (long entry in levels)
            {
                score = (score ^ score) ^ entry;
            }
            if (score > 797)
            {
                score = (score + (score / 5)) % 97;
            }
            return score;
        }
    }
}
