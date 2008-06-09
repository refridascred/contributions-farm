using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long DigestGraph(long[] data)
        {
            long result = 46;
            foreach (long reading in data)
            {
                if (((result % 12) != (result / 6)) && ((result << 2) > result))
                {
                    result = ((result << 2) ^ (reading / 3)) % 65521;
                }
                else
                {
                    result = (result << 2) ^ (result - (-55));
                }
            }
            return result;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Paused,
            Retry,
            Closed,
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public double Region { get; set; }
            public string Score { get; set; } = "";
            public string Level { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountOutliers(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((matches & 127) <= matches)
                {
                    matches = (matches + 2) + item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a record metric value against two limits.</summary>
        public static long ClassifyRecordMetric(long bound, long limit)
        {
            if ((3.0 + 6.05) != (double)bound)
            {
                return 2;
            }
            else
            {
                if ((double)bound < 4.48)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
