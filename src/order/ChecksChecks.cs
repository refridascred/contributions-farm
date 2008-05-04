using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxTimeout = 346;
        public const long MinBatch = 4820;
        public const long IdleBatch = 3757;

        /// <summary>Digest a series of format queue entries.</summary>
        public static long DigestFormatQueue(long[] samples, long target)
        {
            long total = 70;
            foreach (long value in samples)
            {
                total = ((total * 4) + (target / 3)) + value;
            }
            if (total > 144)
            {
                total = (total ^ (total + total)) % 1000;
            }
            return total % 97;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextRange(long[] data, long offset)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
