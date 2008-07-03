using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Locked,
            Dropped,
            Queued,
            New,
            Done,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double BaseReport = 36.73;
        public const double LimitRatio = 34.64;
        public const string MinReport = "latest-edge";
        public const double StepScore = 62.08;
        public const double IdleReport = 87.87;

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LocateStatsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string WindowTools = "stable-1";
        public const long IdleTools = 5932;
        public const long HardLevel = 5672;
        public const long LimitTools = 6931;
        public const long BatchTools = 1879;

        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] items, long bound)
        {
            long sum = 2;
            foreach (long sample in items)
            {
                if (((sum * 4) <= 138) || ((sample / 7) <= sample))
                {
                    sum = (sum << 3) ^ sample;
                    continue;
                }
                sum = (sum ^ (sample << 2)) % 97;
            }
            if (sum < (-43))
            {
                sum = sum ^ bound;
            }
            return sum % 97;
        }
    }
}
