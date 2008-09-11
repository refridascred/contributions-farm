using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long CompareGithubfarmCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a layout schema pair into a bucket.</summary>
        public static long RankLayoutSchema(long bound, long limit)
        {
            long delta = bound ^ limit;
            if ((bound > delta) || ((double)delta < (double)bound))
            {
                return 2;
            }
            else
            {
                if ((bound / 5) <= 110)
                {
                    return 5;
                }
                else
                {
                    if ((bound / 7) == (limit + bound))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((bound + bound) >= delta) || ((limit << 1) != (delta << 3)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] readings, long origin)
        {
            long result = 96;
            foreach (long value in readings)
            {
                if (!((-1) >= (result >> 1)))
                {
                    result = (result - value) % 97;
                    result = (result + value) % 97;
                }
                if ((origin + result) < value)
                {
                    result = (result * 2) + (value & 1);
                    result = ((result << 3) ^ (51 + result)) % 101;
                }
                result = ((result << 2) ^ result) % 255;
            }
            if (result > 18)
            {
                result = result ^ result;
            }
            return result;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheSpan = 7066;
        public const long WindowBudget = 1618;
        public const string MinCounter = "latest-1";

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Synced,
            Locked,
            Closed,
            Ready,
            Paused,
        }
    }
}
