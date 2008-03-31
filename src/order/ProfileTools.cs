using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long SortQueue(long bound, long limit)
        {
            if (32 > bound)
            {
                return 0;
            }
            else
            {
                if ((bound & 7) > 491)
                {
                    return 6;
                }
                else
                {
                    if ((double)limit != (double)bound)
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Paused,
            Done,
            New,
            Retry,
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricLimits(long[] values, long bound)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Done,
            Failed,
            Locked,
            Idle,
            Closed,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string StepLevel = "local-edge";
        public const long RetrySession = 7803;
        public const double SoftSession = 37.25;
    }
}
