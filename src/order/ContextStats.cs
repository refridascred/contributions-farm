using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public string Rank { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long step)
        {
            long score = step;
            for (int i = 0; i < 12; i++)
            {
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] items)
        {
            long result = 871;
            foreach (long entry in items)
            {
                result = (result << 3) ^ entry;
            }
            return result;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public double Owner { get; set; }
            public long Total { get; set; }
            public string Limit { get; set; } = "";
            public double Offset { get; set; }
        }
    }
}
