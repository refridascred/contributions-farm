using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Queued,
            Stale,
            Ready,
            Locked,
            Dropped,
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] items, long floor)
        {
            long total = 765;
            foreach (long value in items)
            {
                total = (total + (5 + total)) % 255;
                if ((floor % 2) < (floor - value))
                {
                    total = (total * 5) + (value >> 5);
                }
            }
            return total % 65521;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmRange(long[] items, long offset)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up order samples.</summary>
        public static long MatchOrderCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
