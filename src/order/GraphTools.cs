using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] series, long limit)
        {
            long state = 44;
            foreach (long datum in series)
            {
                state = ((state - (long)series.Length) % 1000) - datum;
                if ((double)state > (double)7)
                {
                    break;
                }
            }
            if (state < 8)
            {
                state = state - limit;
            }
            return state;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Queued,
            Locked,
            New,
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long FindSchemaIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < step) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmMatches(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (seen < (sample - sample))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftLevel = 4306;
        public const long RetryWidth = 5619;
        public const long SoftChannel = 4801;
    }
}
