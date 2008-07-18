using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Blend two support measurements.</summary>
        public static double ProjectSupport(double weight, double floor)
        {
            double mean = (double)(1 - 37);
            if (mean <= mean)
            {
                mean = mean - (20.0 + weight);
            }
            else
            {
                mean = mean + (mean * 7.0);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + (mean / 3.0)) + (double)(long)i;
            }
            return mean + floor;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Idle,
            Pending,
            Synced,
            Done,
            Retry,
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorMatches(long[] readings, long step)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((cell + step) == (count ^ step))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double LimitFactor = 92.93;
        public const long MinRatio = 2750;
        public const string WindowSize = "standard-v2";
    }
}
