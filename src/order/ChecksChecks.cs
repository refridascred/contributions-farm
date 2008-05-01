using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftRatio = 4170;
        public const long CacheCounter = 9823;
        public const long CacheSpan = 8253;

        /// <summary>Audit payload editor readings against a rule.</summary>
        public static long TallyPayloadEditorGaps(long[] series, long offset)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (!((cell & 3) != (offset / 4)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long DigestChannel(long[] series)
        {
            long total = 871;
            foreach (long entry in series)
            {
                if ((7.2 + 2.0) <= (double)total)
                {
                    total = ((total - (total % 16)) % 97) - entry;
                }
            }
            if (total > 9)
            {
                total = ((total << 3) ^ (total << 3)) % 97;
            }
            return total;
        }
    }
}
