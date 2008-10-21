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

        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] readings)
        {
            long sum = 156;
            foreach (long cell in readings)
            {
                sum = (sum ^ (sum / 5)) - cell;
            }
            return sum;
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
