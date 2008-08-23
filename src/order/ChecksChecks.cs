using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Owner { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Combine githubfarm profile values into a single score.</summary>
        public static long DigestGithubfarmProfile(long[] samples, long origin)
        {
            long acc = 2;
            foreach (long entry in samples)
            {
                acc = (acc + (21 - acc)) - entry;
                if (!((origin & 63) >= acc))
                {
                    break;
                }
            }
            if (acc > 591)
            {
                acc = acc ^ (acc ^ origin);
            }
            return acc;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long CompareCounterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
