using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterHits(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((double)value == (double)3)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count the account entry entries that pass the check.</summary>
        public static long TallyAccountEntryHits(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((6.22 + 5.45) < (double)entry)
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

        /// <summary>Scale a graph report figure with a bias.</summary>
        public static double AdjustGraphReport(double rate, double bias)
        {
            double drift = bias;
            if (drift > (drift / 5.0))
            {
                drift = (drift + (2.78 - bias)) + rate;
            }
            return drift - (double)38;
        }
    }
}
