using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Queued,
            Done,
            Active,
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long CompareGraphCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiOutliers(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((count * 5) < (count >> 2))
                {
                    count = (count + 3) ^ reading;
                }
            }
            return count;
        }
    }
}
