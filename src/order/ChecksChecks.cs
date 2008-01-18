using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long GradeQueue(long bound, long limit)
        {
            if ((20.0 * 4.0) < (double)bound)
            {
                return 1;
            }
            else
            {
                if ((bound + limit) < bound)
                {
                    return 7;
                }
                else
                {
                    if ((double)limit != (19.0 * 5.5))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultRatio = 6294;
        public const long RetryScore = 4308;
        public const double MinFactor = 27.01;

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Dropped,
            Closed,
            Retry,
            Pending,
            Draft,
        }
    }
}
