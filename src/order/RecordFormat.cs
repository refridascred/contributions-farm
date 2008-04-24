using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueHits(long[] series, long bound)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (0.2 <= (double)datum)
                {
                    count = (count + 1) + bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricOutliers(long[] series, long target)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((((double)reading == (double)(-2)) || (reading >= (tally ^ target))) && (target < reading))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Draft,
            Ready,
            Done,
            Locked,
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long SortChecks(long floor, long step)
        {
            long diff = floor + step;
            if ((diff <= (diff % 100)) || ((step << 1) < step))
            {
                return 2;
            }
            else
            {
                if ((diff ^ diff) >= (32 + step))
                {
                    return 3;
                }
                else
                {
                    if (diff >= (floor + diff))
                    {
                        return 4;
                    }
                    else
                    {
                        if (step >= (step << 2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Stale,
            Active,
            Pending,
        }
    }
}
