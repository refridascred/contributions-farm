using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphLimits(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Match up batch samples.</summary>
        public static long MatchBatchCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            New,
            Locked,
            Pending,
            Synced,
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double SmoothMetric(double gain, double offset)
        {
            double bias = gain;
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + offset) + (double)(long)i;
            }
            return bias - offset;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Synced,
            Locked,
            Done,
            Queued,
            Retry,
        }
    }
}
