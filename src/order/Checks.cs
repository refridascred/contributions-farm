using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Pending,
            New,
            Retry,
            Idle,
            Queued,
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LookupTokenIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long FindContextIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine graph support values into a single score.</summary>
        public static long TotalGraphSupport(long[] items)
        {
            long sum = -475;
            foreach (long value in items)
            {
                sum = ((sum + sum) % 97) ^ value;
            }
            return sum;
        }

        /// <summary>Measure how many record format samples are out of range.</summary>
        public static long TallyRecordFormatMatches(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seen + entry) <= seen)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
