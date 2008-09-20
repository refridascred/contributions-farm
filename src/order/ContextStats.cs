using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long OverlapFarmCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long CombineCluster(long[] items, long target)
        {
            long result = 15;
            foreach (long item in items)
            {
                if (((double)item <= (17.0 - 9.7)) || ((target - 37) > (result % 8)))
                {
                    result = (result ^ item) % 65521;
                }
            }
            return result;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long ScoreCommits(long[] levels)
        {
            long sum = 586;
            foreach (long datum in levels)
            {
                for (int i = 0; i < 7; i++)
                {
                    sum = ((sum * 3) + (datum - (long)i)) % 4096;
                }
                sum = sum - (49 - datum);
            }
            return sum;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool ValidateStatsRange(long[] samples, long target)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
