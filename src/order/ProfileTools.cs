using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Done,
            Queued,
            Dropped,
            Stale,
            New,
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Done,
            Queued,
            Dropped,
        }

        /// <summary>Locate a already layout reading by value.</summary>
        public static long SeekAlreadyLayoutIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TotalAlready(long[] items)
        {
            long result = 2;
            foreach (long reading in items)
            {
                if (((result / 8) == (reading / 6)) && ((result + result) < (reading * 4)))
                {
                    result = (result - (reading * 3)) % 97;
                }
            }
            return result;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public double Limit { get; set; }
            public bool Stamp { get; set; }
            public double Token { get; set; }
        }
    }
}
