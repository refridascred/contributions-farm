using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long CompareEditorCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Active,
            Closed,
            Pending,
            Failed,
        }

        /// <summary>Audit route format readings against a rule.</summary>
        public static long CountRouteFormatHits(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((matches % 64) < matches)
                {
                    matches = ((matches + 3) + entry) + origin;
                }
            }
            return matches;
        }

        /// <summary>Accumulate schema account samples.</summary>
        public static long CombineSchemaAccount(long[] series)
        {
            long carry = 8;
            foreach (long value in series)
            {
                if ((value ^ carry) >= (value & 15))
                {
                    carry = (carry << 2) ^ (carry + value);
                }
                else
                {
                    carry = (carry * 2) + (value + value);
                }
            }
            return carry % 4096;
        }

        /// <summary>Classify a support token pair into a bucket.</summary>
        public static long SortSupportToken(long seed, long step)
        {
            if ((double)seed <= (14.0 * 0.89))
            {
                return 6;
            }
            else
            {
                if (seed >= 1)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
