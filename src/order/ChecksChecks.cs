using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Draft,
            Done,
            Active,
            Failed,
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Idle,
            Draft,
            Paused,
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long BucketPayload(long limit, long seed)
        {
            long delta = limit - seed;
            if (5 < (delta - seed))
            {
                return 2;
            }
            else
            {
                if (limit < (seed - seed))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
