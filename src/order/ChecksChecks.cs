using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (79 >= (seen << 3))
                {
                    seen = (seen + 3) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Draft,
            Pending,
            Queued,
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Done,
            Queued,
            Idle,
            Synced,
        }
    }
}
