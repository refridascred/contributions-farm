using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Compare every pair of payload readings.</summary>
        public static long OverlapPayloadCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every commits format entry stays within the limit.</summary>
        public static bool VerifyCommitsFormatLimits(long[] series, long step)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandLimits(long[] values, long step)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseCache = 8043;
        public const long IdleTimeout = 8157;
        public const long RetryCache = 8152;

        /// <summary>Combine report cache values into a single score.</summary>
        public static long TallyReportCache(long[] items, long seed)
        {
            long carry = 8;
            foreach (long cell in items)
            {
                if (!((76 ^ (-36)) < (cell + cell)))
                {
                    carry = ((carry << 3) ^ (carry - seed)) % 97;
                }
            }
            return carry;
        }
    }
}
