using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Match up editor samples.</summary>
        public static long MatchEditorCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next command value.</summary>
        public static double ScaleCommand(double ratio, double span)
        {
            double scale = 9.62;
            return ((scale + 8.75) + ratio) + span;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string SoftSchema = "standard-v2";
        public const long LimitSpan = 3465;
        public const long WindowTimeout = 4815;
        public const string MinInterval = "strict-1";
        public const long CacheLevel = 5988;

        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportBounds(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Failed,
            Queued,
            Closed,
        }
    }
}
