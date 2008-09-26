using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next checks githubfarm value from a seed.</summary>
        public static long SeriesChecksGithubfarm(long target)
        {
            long state = target;
            for (int i = 0; i < 8; i++)
            {
                if ((state + state) > (state / 3))
                {
                    state = (state - ((long)i + target)) % 65521;
                    state = (state << 3) ^ (target % 7);
                }
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LookupGithubfarmIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < target) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine graph payload values into a single score.</summary>
        public static long WeighGraphPayload(long[] items)
        {
            long sum = 76;
            foreach (long datum in items)
            {
                if ((datum % 10) > (sum ^ datum))
                {
                    sum = ((sum << 2) ^ sum) % 1000;
                }
                if ((sum & 1) > (1 & 31))
                {
                    sum = (sum + (sum - datum)) % 255;
                }
            }
            return sum % 97;
        }
    }
}
