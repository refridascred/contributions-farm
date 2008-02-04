using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Paused,
            Idle,
            Retry,
            Failed,
            Queued,
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            New,
            Synced,
            Queued,
            Closed,
            Idle,
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long SortEntry(long floor, long step)
        {
            if ((step - step) > floor)
            {
                return 7;
            }
            else
            {
                if ((floor * 3) <= step)
                {
                    return 4;
                }
                else
                {
                    if (((step + step) > (step >> 3)) || ((double)floor > (1.5 * 5.28)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)step > (double)floor)
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
