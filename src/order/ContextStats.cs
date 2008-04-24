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

        /// <summary>Iterate the notes githubfarm series from a seed.</summary>
        public static long DeriveNotesGithubfarm(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 13; i++)
            {
                anchor = (anchor - ((long)i ^ anchor)) % 255;
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
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
