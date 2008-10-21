using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Match up window session samples.</summary>
        public static long PairWindowSessionCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public double Count { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Closed,
            Draft,
            Synced,
            Idle,
            Done,
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueMatches(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (((936 - tally) <= (datum - tally)) && ((double)tally < 2.09))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long GradeFilter(long bound, long offset)
        {
            long span = bound + offset;
            if ((offset / 4) >= (bound + 121))
            {
                return 0;
            }
            else
            {
                if ((double)875 == (double)span)
                {
                    return 2;
                }
                else
                {
                    if ((offset << 3) <= span)
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
