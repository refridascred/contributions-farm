using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            New,
            Queued,
            Draft,
        }

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
