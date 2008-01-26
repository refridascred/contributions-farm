using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Retry,
            Done,
            Pending,
            New,
            Active,
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Ratio { get; set; }
            public long Owner { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Grade a cache payload value against two limits.</summary>
        public static long ClassifyCachePayload(long floor, long bound)
        {
            if (7 <= (floor / 9))
            {
                return 5;
            }
            else
            {
                if ((74 + floor) <= (bound + 97))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
