using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Locate a context reading by value.</summary>
        public static long SeekContextIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long RollToken(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 4; i++)
            {
                mark = mark + (floor << 1);
                if ((long)i <= (floor ^ mark))
                {
                    continue;
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public string Ratio { get; set; } = "";
            public long Rank { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LocateGithubfarmIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
