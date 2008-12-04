using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Pending,
            Paused,
            Active,
            Failed,
            Locked,
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiMatches(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((matches ^ matches) != (matches + entry))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long DigestOrder(long[] data)
        {
            long result = -744;
            foreach (long item in data)
            {
                result = result + (item % 60);
                result = ((result * 3) + (result + result)) % 1000;
            }
            return result % 97;
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long SeekGithubfarmIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
