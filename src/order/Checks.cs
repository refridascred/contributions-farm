using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmGaps(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((hits + value) <= 65)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long step, long seed)
        {
            long bound = step ^ seed;
            if ((step & 255) <= seed)
            {
                return 1;
            }
            else
            {
                if ((2 << 3) < (seed - step))
                {
                    return 4;
                }
                else
                {
                    if ((bound + bound) == (bound % 60))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] items)
        {
            long score = 1;
            foreach (long cell in items)
            {
                if (cell < (cell ^ score))
                {
                    score = ((score << 2) ^ (cell >> 5)) % 97;
                }
                else
                {
                    score = (score + (score + score)) % 65521;
                }
                score = score + (score + score);
            }
            return score;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Failed,
            Pending,
            Queued,
            Paused,
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public string Label { get; set; } = "";
            public long Region { get; set; }
            public long Stamp { get; set; }
        }
    }
}
