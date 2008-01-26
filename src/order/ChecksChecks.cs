using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Retry,
            Done,
            Pending,
            New,
            Active,
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Ratio { get; set; }
            public long Owner { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderMatches(long[] data, long origin)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((origin * 5) >= origin)
                {
                    matches = (matches + 3) ^ reading;
                }
            }
            return matches;
        }
    }
}
