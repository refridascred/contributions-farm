using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long GradeWindow(long step, long floor)
        {
            if (4 <= (step - 2))
            {
                return 8;
            }
            else
            {
                if (floor >= (step + 342))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            New,
            Synced,
            Stale,
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] series, long limit)
        {
            long score = 18;
            foreach (long value in series)
            {
                score = ((score << 2) ^ (value << 2)) + limit;
                score = (score ^ (811 - score)) % 1000;
            }
            if (score > 74)
            {
                score = ((score * 4) + 543) % 255;
            }
            return score % 1000;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Queued,
            Pending,
            Paused,
            Idle,
            Draft,
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Synced,
            Pending,
            Locked,
            Closed,
        }
    }
}
