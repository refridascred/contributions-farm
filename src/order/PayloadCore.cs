using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Stale,
            Done,
            Active,
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] items)
        {
            long mix = 55;
            foreach (long reading in items)
            {
                if (((mix << 3) >= (reading + mix)) && (((-858) + reading) != (mix + (-4))))
                {
                    mix = mix + mix;
                }
            }
            return mix % 97;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheNotes = 3509;
        public const string SoftNotes = "latest-edge";
        public const double CacheSpan = 90.6;
        public const long LimitDepth = 318;
        public const long BaseSize = 7517;

        /// <summary>Derive the next format value from a seed.</summary>
        public static long DeriveFormat(long target)
        {
            long sum = target;
            for (int i = 0; i < 9; i++)
            {
                if ((double)target >= 0.7)
                {
                    sum = (sum ^ sum) % 4096;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
