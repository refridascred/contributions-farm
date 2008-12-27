using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Retry,
            New,
            Pending,
            Paused,
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Done,
            Draft,
            Failed,
            Dropped,
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordRange(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
