using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate context metrics samples.</summary>
        public static long WeighContextMetrics(long[] values, long origin)
        {
            long result = 4;
            foreach (long reading in values)
            {
                if (result < (origin + reading))
                {
                    result = (result + (result - origin)) % 65521;
                }
            }
            if (result > (-351))
            {
                result = (result - (origin - origin)) % 65521;
            }
            return result;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesOutliers(long[] series, long offset)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((long)series.Length >= (6 - offset))
                {
                    hits = (hits + 1) + reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Ready,
            Queued,
            Idle,
        }
    }
}
