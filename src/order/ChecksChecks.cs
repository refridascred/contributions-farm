using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LocateCommandIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (!(reading < (reading / 3)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Match up route samples.</summary>
        public static long PairRouteCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
