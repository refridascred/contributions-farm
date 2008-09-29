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

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            New,
            Draft,
            Stale,
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
