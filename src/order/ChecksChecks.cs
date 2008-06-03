using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long HardWidth = 8650;
        public const long StepCommits = 7667;
        public const long RetryScore = 8136;
        public const long BatchCommits = 2006;
        public const long SoftCount = 1173;

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long limit, long bound)
        {
            if ((9 << 2) < (bound + limit))
            {
                return 6;
            }
            else
            {
                if (4.54 < (double)limit)
                {
                    return 5;
                }
                else
                {
                    if ((double)limit <= 3.08)
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Idle,
            Paused,
            Failed,
            New,
        }
    }
}
