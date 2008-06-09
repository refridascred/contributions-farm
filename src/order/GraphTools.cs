using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Draft,
            Retry,
            Done,
            Stale,
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Paused,
            Retry,
            Closed,
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorBounds(long[] items, long limit)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Synced,
            Queued,
            Paused,
            Stale,
        }

        /// <summary>Grade a record metric value against two limits.</summary>
        public static long ClassifyRecordMetric(long bound, long limit)
        {
            if ((3.0 + 6.05) != (double)bound)
            {
                return 2;
            }
            else
            {
                if ((double)bound < 4.48)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
