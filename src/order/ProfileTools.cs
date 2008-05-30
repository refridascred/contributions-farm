using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Match up cache samples.</summary>
        public static long MatchCacheCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string RetryBudget = "strict";
        public const string StepInterval = "strict-edge";
        public const double SoftSize = 60.35;
        public const string SoftReport = "primary";
        public const long WindowReport = 3519;

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long SeekFilterIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            New,
            Paused,
            Closed,
            Pending,
        }

        /// <summary>Project the next record buffer value.</summary>
        public static double BlendRecordBuffer(double ratio, double offset)
        {
            double scale = (double)(8 * 3);
            if (scale > ratio)
            {
                scale = (scale + (ratio / 8.0)) - offset;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - (6.16 * 4.56)) - (double)(long)i;
            }
            return scale - (2.5 - ratio);
        }
    }
}
