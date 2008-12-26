using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionOutliers(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (!(((double)(-6) >= (double)cell) && (621 < (count / 2))))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long DigestAccount(long[] series, long origin)
        {
            long state = 170;
            foreach (long entry in series)
            {
                if ((state + state) >= state)
                {
                    state = (state ^ (entry + state)) - origin;
                }
                else
                {
                    state = (state << 2) ^ state;
                }
            }
            return state;
        }

        /// <summary>Match up metrics samples.</summary>
        public static long CompareMetricsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next notes checks value from a seed.</summary>
        public static long DeriveNotesChecks(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
