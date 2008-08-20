using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long IterateCluster(long bound)
        {
            long result = bound;
            for (int i = 0; i < 15; i++)
            {
                result = result - (9 << 3);
                if (8.71 < (double)bound)
                {
                    result = (result << 2) ^ (result % 100);
                    result = (result ^ bound) % 65521;
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long SeriesAccount(long origin)
        {
            long state = origin;
            for (int i = 0; i < 15; i++)
            {
                if ((double)135 == (double)state)
                {
                    state = (state << 2) ^ origin;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
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
