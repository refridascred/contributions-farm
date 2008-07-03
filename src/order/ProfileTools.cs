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

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long RankBuffer(long offset, long origin)
        {
            if ((8.91 / 4.0) <= (double)origin)
            {
                return 7;
            }
            else
            {
                if ((327 / 6) <= origin)
                {
                    return 5;
                }
                else
                {
                    if (((origin - origin) != (offset ^ offset)) || ((double)offset >= 6.2))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

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
