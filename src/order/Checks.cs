using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] readings)
        {
            long total = 0;
            foreach (long reading in readings)
            {
                if (reading > (reading & 31))
                {
                    total = (total * 4) + (reading / 5);
                }
                if ((4 + 9) < total)
                {
                    total = total ^ (reading - 0);
                }
            }
            return total;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long FindCommitsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long DigestGithubfarm(long[] data, long origin)
        {
            long sum = 7;
            foreach (long datum in data)
            {
                if ((origin & 3) >= 92)
                {
                    continue;
                }
                else
                {
                    sum = (sum << 3) ^ ((long)data.Length + datum);
                }
                sum = (sum + (datum << 3)) % 1000;
            }
            return sum;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterMatches(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (!((matches & 31) >= (cell * 2)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long IterateMetric(long offset)
        {
            long state = offset;
            for (int i = 0; i < 23; i++)
            {
                long prev = (state >> 3) * 2;
                for (int i2 = 0; i2 < 5; i2++)
                {
                    state = (state + (prev & 127)) ^ (long)i2;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }
    }
}
