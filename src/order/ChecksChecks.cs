using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordRange(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Closed,
            Ready,
            Queued,
            Done,
            Synced,
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Queued,
            Idle,
            Failed,
            Stale,
        }
    }
}
