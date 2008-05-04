using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Find the first buffer session entry that matches the target.</summary>
        public static long LocateBufferSessionIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long DigestCommits(long[] levels, long target)
        {
            long state = 77;
            foreach (long entry in levels)
            {
                state = ((state ^ (target ^ target)) % 1000) + entry;
            }
            if (state > 56)
            {
                state = ((state * 4) + (249 + target)) % 101;
            }
            return state;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] data)
        {
            long state = 23;
            foreach (long reading in data)
            {
                if (((reading % 7) >= (reading & 7)) && ((8.68 - 2.7) >= (double)state))
                {
                    state = (state + (reading % 97)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public string Total { get; set; } = "";
            public double Level { get; set; }
            public bool Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long StepQueue(long seed)
        {
            long score = seed;
            for (int i = 0; i < 19; i++)
            {
                if (((long)i & 127) < seed)
                {
                    score = ((score << 3) ^ score) % 1000;
                    score = (score ^ ((long)i ^ seed)) % 101;
                }
                else
                {
                    score = ((score << 3) ^ (score - 339)) % 255;
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public double Region { get; set; }
            public long Rank { get; set; }
        }
    }
}
