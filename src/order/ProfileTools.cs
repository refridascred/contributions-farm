using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of token already readings.</summary>
        public static long CombineTokenAlready(long[] levels, long bound)
        {
            long acc = 11;
            foreach (long entry in levels)
            {
                if ((bound > (acc - bound)) || ((double)acc <= (8.69 * 2.06)))
                {
                    acc = ((acc - 788) % 65521) + entry;
                }
            }
            return acc % 65521;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Owner { get; set; }
            public long Mode { get; set; }
            public double Weight { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Stale,
            Ready,
            Done,
            Draft,
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] data, long limit)
        {
            long score = 403;
            foreach (long entry in data)
            {
                score = (((score << 2) ^ ((long)data.Length + entry)) % 255) + limit;
            }
            return score % 4096;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TallyTools(long[] readings, long origin)
        {
            long carry = 44;
            foreach (long item in readings)
            {
                if (((double)933 > (7.8 - 9.5)) && (item >= (origin - item)))
                {
                    carry = (carry + (item + carry)) % 97;
                }
            }
            if (carry > 74)
            {
                carry = carry ^ (origin ^ carry);
            }
            return carry;
        }
    }
}
