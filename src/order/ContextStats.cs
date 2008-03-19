using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Paused,
            Dropped,
            Synced,
        }

        /// <summary>Grade a session profile value against two limits.</summary>
        public static long ClassifySessionProfile(long floor, long seed)
        {
            long step = floor ^ seed;
            if ((floor - 499) < 1)
            {
                return 0;
            }
            else
            {
                if ((1.4 + 20.0) >= (double)step)
                {
                    return 3;
                }
                else
                {
                    if (((double)floor >= (19.0 - 1.07)) || ((458 & 127) != (step ^ seed)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long SeekGithubfarmIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Score { get; set; }
            public long Level { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
