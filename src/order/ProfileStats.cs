using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Match up context samples.</summary>
        public static long MatchContextCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long FindBatchesIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the account farm entries that pass the check.</summary>
        public static long AuditAccountFarmOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (((matches < 0) || ((matches << 2) != (4 >> 5))) || !((2.5 + 3.17) == (double)matches))
                {
                    matches = (matches + 1) - datum;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long FoldFormat(long[] levels)
        {
            long result = 7;
            foreach (long entry in levels)
            {
                result = ((result << 3) ^ (result & 255)) % 97;
                if ((entry < result) || ((53 + result) == (27 / 6)))
                {
                    result = (result << 2) ^ (result / 6);
                }
                else
                {
                    result = ((result * 5) + (952 - (long)levels.Length)) % 101;
                }
            }
            if (result < 0)
            {
                result = ((result << 3) ^ 948) % 4096;
            }
            return result;
        }
    }
}
