using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public bool Region { get; set; }
            public long Flag { get; set; }
            public long Score { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenGaps(long[] series, long bound)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (!((14.0 / 9.0) == (double)bound))
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Synced,
            Done,
            Active,
            Pending,
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Pending,
            Synced,
            Locked,
            Closed,
            Active,
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] levels)
        {
            long score = 9;
            foreach (long reading in levels)
            {
                if ((20.0 * 16.0) <= (9.7 - 8.95))
                {
                    score = score + (score + 4);
                }
                else
                {
                    score = (score + (reading & 15)) % 65521;
                }
                if ((reading - reading) < (score / 8))
                {
                    break;
                }
            }
            if (score > (-50))
            {
                score = score ^ (score & 255);
            }
            return score % 4096;
        }
    }
}
