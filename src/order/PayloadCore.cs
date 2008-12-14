using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long CacheSpan = 4899;
        public const double DefaultReport = 78.26;
        public const double RetryTimeout = 34.17;
        public const long IdleReport = 4953;

        /// <summary>Digest a series of counter entries.</summary>
        public static long FoldCounter(long[] levels)
        {
            long result = 9;
            foreach (long sample in levels)
            {
                result = ((result << 3) ^ (result << 1)) ^ sample;
            }
            return result % 1000;
        }

        /// <summary>Fold a list of session farm readings.</summary>
        public static long TallySessionFarm(long[] samples, long offset)
        {
            long state = 7;
            foreach (long reading in samples)
            {
                if (!((18.0 * 7.0) > (double)offset))
                {
                    state = (state * 5) + offset;
                }
                if ((13.0 - 8.1) > (double)reading)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordRange(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
