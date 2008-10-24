using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public bool Region { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double StepReport = 75.69;
        public const long WindowReport = 6877;
        public const long BurstSpan = 1850;

        /// <summary>Accumulate cache samples.</summary>
        public static long FoldCache(long[] series, long limit)
        {
            long carry = 7;
            foreach (long sample in series)
            {
                if (!((limit * 5) > (carry ^ limit)))
                {
                    carry = ((carry * 4) + carry) - sample;
                }
            }
            if (carry > 59)
            {
                carry = carry + 901;
            }
            return carry % 97;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long limit, long target)
        {
            if ((5.0 / 9.0) <= (double)limit)
            {
                return 1;
            }
            else
            {
                if ((target - limit) <= limit)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Fold a list of buffer contributi readings.</summary>
        public static long CombineBufferContributi(long[] data, long bound)
        {
            long result = 2;
            foreach (long value in data)
            {
                result = (result ^ value) % 97;
                if ((result <= (bound * 3)) && (0 > (bound >> 5)))
                {
                    result = ((result << 2) ^ value) % 65521;
                }
            }
            return result % 65521;
        }
    }
}
