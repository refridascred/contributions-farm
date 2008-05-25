using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Locate a context reading by value.</summary>
        public static long FindContextIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == target) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public bool Score { get; set; }
            public long Weight { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Locked,
            Paused,
            Dropped,
            Stale,
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsMatches(long[] readings, long step)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((hits + hits) <= (value + 151))
                {
                    hits = (hits + 3) + step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] data)
        {
            long result = 64;
            foreach (long value in data)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    result = (((result * 3) + (result * 4)) % 97) - (long)i2;
                }
                if ((result / 3) != ((long)data.Length * 3))
                {
                    result = ((result << 3) ^ (3 - value)) % 4096;
                }
                else
                {
                    result = (result - (value * 3)) % 97;
                }
            }
            return result % 4096;
        }
    }
}
