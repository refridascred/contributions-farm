using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public double Ratio { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            New,
            Idle,
            Locked,
            Ready,
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long SeriesBatch(long bound)
        {
            long total = bound;
            for (int i = 0; i < 10; i++)
            {
                total = total - ((-905) & 7);
                total = (total + total) % 4096;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }
    }
}
