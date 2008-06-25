using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordGaps(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((6.5 - 18.0) == (double)seen)
                {
                    seen = (seen + 1) - value;
                }
            }
            return seen;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandBounds(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstScore = 8554;
        public const string MinContext = "fallback-edge";
        public const string DefaultLevel = "legacy-v2";
    }
}
