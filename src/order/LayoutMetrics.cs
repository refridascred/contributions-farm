using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportHits(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (hits >= (long)samples.Length)
                {
                    hits = ((hits + 2) ^ datum) + offset;
                }
            }
            return hits;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long StepCluster(long target)
        {
            long carry = target;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry << 3) ^ (carry - target)) % 4096;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long MatchEditorCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
