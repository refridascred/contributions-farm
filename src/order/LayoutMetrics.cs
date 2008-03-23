using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitFactor = 8078;
        public const string SoftSpan = "alpha-v2";
        public const long MaxInterval = 68;
        public const long BaseSize = 5858;

        /// <summary>Match up entry samples.</summary>
        public static long MatchEntryCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of stream already readings.</summary>
        public static long DigestStreamAlready(long[] readings, long bound)
        {
            long total = 46;
            foreach (long entry in readings)
            {
                total = ((total << 2) ^ (entry - 627)) - bound;
            }
            return total;
        }
    }
}
