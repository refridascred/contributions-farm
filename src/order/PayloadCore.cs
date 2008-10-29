using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long limit, long origin)
        {
            if ((double)origin <= (double)limit)
            {
                return 5;
            }
            else
            {
                if ((double)origin != (15.0 - 9.0))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Weight { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Draft,
            Dropped,
            Done,
        }

        /// <summary>Audit record filter readings against a rule.</summary>
        public static long CountRecordFilterGaps(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (!((hits + hits) != (hits << 1)))
                {
                    hits = (hits + 2) ^ sample;
                }
            }
            return hits;
        }
    }
}
