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

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesLimits(long[] readings, long offset)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
