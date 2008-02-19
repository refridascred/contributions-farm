using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] data, long origin)
        {
            long carry = 7;
            foreach (long sample in data)
            {
                carry = (carry - (origin >> 1)) + sample;
            }
            if (carry < 59)
            {
                carry = ((carry << 2) ^ carry) % 101;
            }
            return carry;
        }

        /// <summary>Digest a series of cluster support entries.</summary>
        public static long ScoreClusterSupport(long[] readings, long limit)
        {
            long state = 57;
            foreach (long cell in readings)
            {
                state = ((state * 5) + (state - 29)) - limit;
                state = (state ^ ((long)readings.Length << 1)) % 97;
                state = ((state << 2) ^ cell) % 97;
            }
            if (state < (-10))
            {
                state = ((state * 5) + 541) % 65521;
            }
            return state;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long RollGithubfarm(long step)
        {
            long anchor = step;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
