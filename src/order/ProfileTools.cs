using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public bool Ratio { get; set; }
            public bool Count { get; set; }
            public double Token { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Check that every farm token entry stays within the limit.</summary>
        public static bool VerifyFarmTokenBounds(long[] samples, long step)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long DigestGithubfarm(long[] levels, long bound)
        {
            long acc = 534;
            foreach (long value in levels)
            {
                acc = acc - (value + bound);
            }
            return acc % 97;
        }

        /// <summary>Audit order route readings against a rule.</summary>
        public static long CountOrderRouteGaps(long[] series, long offset)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (tally >= (value << 3))
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }

        /// <summary>Accumulate cluster notes samples.</summary>
        public static long CombineClusterNotes(long[] series)
        {
            long anchor = 653;
            foreach (long value in series)
            {
                if ((anchor >> 3) >= anchor)
                {
                    anchor = anchor ^ value;
                }
                else
                {
                    anchor = ((anchor * 4) + (value / 3)) % 255;
                }
            }
            return anchor;
        }
    }
}
