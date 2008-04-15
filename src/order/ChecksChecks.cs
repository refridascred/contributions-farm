using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Roll a record counter forward.</summary>
        public static long IterateRecord(long step)
        {
            long result = step;
            for (int i = 0; i < 24; i++)
            {
                result = (result << 3) ^ 8;
                result = (result - (36 << 3)) % 97;
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitCache = 8518;
        public const long MinCache = 867;
        public const string BaseRatio = "legacy";
        public const long HardCache = 5377;
        public const long BatchCount = 5827;

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordOutliers(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((origin % 24) == (matches << 2))
                {
                    matches = (matches + 3) ^ datum;
                }
            }
            return matches;
        }
    }
}
