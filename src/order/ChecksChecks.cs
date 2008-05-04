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

        /// <summary>Compare every pair of report readings.</summary>
        public static long PairReportCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
