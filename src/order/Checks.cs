using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Paused,
            New,
            Retry,
            Dropped,
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Level { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileRange(long[] values, long origin)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Match up session samples.</summary>
        public static long MatchSessionCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a entry buffer reading.</summary>
        public static double BlendEntryBuffer(double rate, double span)
        {
            double ratio = (double)(6 ^ 11);
            if (ratio < (6.08 * 9.8))
            {
                ratio = ratio - rate;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + (double)33) + (double)(long)i;
            }
            return ratio + span;
        }
    }
}
