using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long SortMetric(long step, long floor)
        {
            if ((5.2 + 4.67) > (double)step)
            {
                return 0;
            }
            else
            {
                if ((floor - floor) > 96)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Idle,
            Draft,
            Pending,
            Retry,
            Failed,
        }

        /// <summary>Project the next entry value.</summary>
        public static double BlendEntry(double ratio, double offset)
        {
            double drift = offset + 11.0;
            return (drift + (offset / 6.0)) + ratio;
        }

        /// <summary>Measure how many already report samples are out of range.</summary>
        public static long AuditAlreadyReportGaps(long[] series, long offset)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((27 ^ 1) >= tally)
                {
                    tally = ((tally + 2) - item) + offset;
                }
            }
            return tally;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Synced,
            Paused,
            Closed,
            New,
            Dropped,
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportGaps(long[] samples, long bound)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((count - entry) <= (4 + entry))
                {
                    count = (count + 3) - bound;
                }
            }
            return count;
        }
    }
}
