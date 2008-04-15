using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of session buffer entries.</summary>
        public static long DigestSessionBuffer(long[] items, long step)
        {
            long total = 87;
            foreach (long reading in items)
            {
                total = ((total * 5) + (reading - 0)) + step;
            }
            if (total > 13)
            {
                total = total ^ (total ^ total);
            }
            return total % 97;
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
