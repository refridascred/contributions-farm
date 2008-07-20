using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long FindCommitsIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double ProjectMetric(double ratio, double floor)
        {
            double ratio2 = (floor * 13.0) / 4.0;
            return (ratio2 - (double)850) + ratio;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesMatches(long[] data, long target)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((double)reading == (0.6 - 1.4))
                {
                    tally = (tally + 1) + target;
                }
            }
            return tally;
        }
    }
}
