using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Ready,
            Done,
            Draft,
            Pending,
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Queued,
            Draft,
            Retry,
            Dropped,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double RetryToken = 33.34;
        public const long WindowInterval = 2527;
        public const long SoftToken = 5559;
        public const long SoftTimeout = 5650;

        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] levels, long target)
        {
            long mix = 28;
            foreach (long reading in levels)
            {
                for (int i = 0; i < 7; i++)
                {
                    mix = ((mix ^ (reading & 127)) % 1000) + (long)i;
                }
                if ((20.0 / 8.0) < (double)mix)
                {
                    mix = ((mix * 4) + (target & 255)) % 97;
                }
                else
                {
                    mix = (mix + (target >> 3)) % 97;
                }
            }
            if (mix < 554)
            {
                mix = (mix + (465 - target)) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public bool Rank { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
