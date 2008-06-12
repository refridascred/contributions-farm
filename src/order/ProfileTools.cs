using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] samples, long offset)
        {
            long carry = 6;
            foreach (long item in samples)
            {
                if ((carry % 100) < (carry / 2))
                {
                    carry = (carry + (carry & 1)) - item;
                }
                else
                {
                    carry = (carry - (carry - offset)) % 101;
                }
                if ((5.8 / 2.0) > (double)(long)samples.Length)
                {
                    break;
                }
            }
            return carry % 4096;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long PairGraphCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            New,
            Locked,
            Draft,
        }

        /// <summary>Measure how many record counter samples are out of range.</summary>
        public static long TallyRecordCounterGaps(long[] items, long offset)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((double)count <= 4.51)
                {
                    count = ((count + 3) - datum) + offset;
                }
            }
            return count;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double HardInterval = 24.39;
        public const double BaseGraph = 26.63;
        public const long BurstGraph = 2786;
        public const string IdleGraph = "fallback-v2";
    }
}
