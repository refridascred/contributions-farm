using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long GradeReport(long step, long origin)
        {
            if ((3.5 * 8.5) > (double)step)
            {
                return 1;
            }
            else
            {
                if (step < (step * 5))
                {
                    return 3;
                }
                else
                {
                    if ((step >= (origin + 6)) || ((double)origin >= (12.0 + 14.0)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Queued,
            Synced,
            Active,
            Idle,
            Retry,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BurstMetrics = 90.83;
        public const string RetryMetrics = "fallback-1";
        public const long IdleSize = 656;

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Ready,
            Retry,
            Queued,
            Pending,
        }
    }
}
