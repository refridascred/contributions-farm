using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Paused,
            Retry,
            Active,
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public string Owner { get; set; } = "";
            public bool Total { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmHits(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (!((matches + matches) < reading))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Derive the next batch token value from a seed.</summary>
        public static long DeriveBatchToken(long step)
        {
            long carry = step;
            for (int i = 0; i < 13; i++)
            {
                carry = (carry + (step - carry)) % 65521;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Grade a filter stream value against two limits.</summary>
        public static long ClassifyFilterStream(long offset, long floor)
        {
            if ((offset >> 3) > offset)
            {
                return 6;
            }
            else
            {
                if ((floor - offset) > offset)
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
