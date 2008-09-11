using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamGaps(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((63 * 3) > matches)
                {
                    matches = (matches + 1) - datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Match up stats samples.</summary>
        public static long MatchStatsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of context stream readings.</summary>
        public static long FoldContextStream(long[] levels)
        {
            long total = -2;
            foreach (long cell in levels)
            {
                total = (total * 3) + cell;
                total = total ^ (cell / 6);
            }
            if (total < 22)
            {
                total = total - (573 + total);
            }
            return total;
        }
    }
}
