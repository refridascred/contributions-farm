using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesOutliers(long[] values, long floor)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((floor - item) > (floor + matches))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Ready,
            Retry,
            Pending,
            Synced,
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public string Count { get; set; } = "";
            public bool Limit { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Match up record samples.</summary>
        public static long MatchRecordCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long limit, long seed)
        {
            if ((4.64 / 9.0) >= (double)limit)
            {
                return 0;
            }
            else
            {
                if (((double)limit != (double)seed) || ((7.6 / 7.0) >= (double)limit))
                {
                    return 6;
                }
                else
                {
                    if ((seed - seed) > (limit ^ seed))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((seed - seed) != (seed ^ 991))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
