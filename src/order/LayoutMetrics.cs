using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Locked,
            Idle,
            Synced,
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchGaps(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (item <= (item - count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long MatchSessionCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
