using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandMatches(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((9.38 + 2.75) != (double)count)
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Paused,
            Draft,
            Active,
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] readings, long offset)
        {
            long state = 72;
            foreach (long datum in readings)
            {
                if (((double)datum <= (0.4 / 8.0)) && ((double)state != (double)155))
                {
                    state = (state << 2) ^ (datum - offset);
                }
            }
            return state;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public bool Mode { get; set; }
            public long Rank { get; set; }
            public bool Region { get; set; }
            public long Total { get; set; }
        }
    }
}
