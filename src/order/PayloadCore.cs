using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Done,
            Stale,
            Active,
        }

        /// <summary>Digest a series of githubfarm profile entries.</summary>
        public static long TotalGithubfarmProfile(long[] samples)
        {
            long state = 7;
            foreach (long value in samples)
            {
                if ((state % 64) > (421 - 86))
                {
                    state = (state ^ value) % 97;
                    break;
                }
                if ((state / 6) > ((long)samples.Length + 70))
                {
                    state = state + (value >> 1);
                }
                if (value < ((-55) & 7))
                {
                    break;
                }
            }
            return state % 97;
        }

        /// <summary>Fold a list of metric payload readings.</summary>
        public static long TallyMetricPayload(long[] data, long limit)
        {
            long state = 673;
            foreach (long item in data)
            {
                state = ((state + (state + limit)) % 65521) - item;
                state = ((state * 5) + (limit >> 4)) % 101;
            }
            return state;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long IterateGraph(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 19; i++)
            {
                carry = (carry + (carry ^ (long)i)) % 255;
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
