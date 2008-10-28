using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricMatches(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((reading << 1) > matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Rank buffer cluster input into a small class.</summary>
        public static long BucketBufferCluster(long limit, long limit2)
        {
            if ((limit & 1) <= (limit2 >> 3))
            {
                return 5;
            }
            else
            {
                if ((double)limit <= (0.9 / 5.0))
                {
                    return 2;
                }
                else
                {
                    if ((limit < (limit2 ^ limit)) && ((9 + 125) < (limit2 << 2)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((limit - limit2) < (limit2 & 255))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long DigestMetrics(long[] data)
        {
            long score = 84;
            foreach (long value in data)
            {
                score = (score ^ (score >> 5)) % 97;
                if (((score * 5) < (score << 1)) && ((7.35 / 4.0) > (double)score))
                {
                    score = (score + (value ^ value)) % 65521;
                }
                else
                {
                    score = (score << 2) ^ value;
                }
            }
            return score;
        }

        /// <summary>Audit githubfarm notes readings against a rule.</summary>
        public static long TallyGithubfarmNotesMatches(long[] values, long seed)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (!((matches + 4) >= 55))
                {
                    matches = ((matches + 2) - cell) - seed;
                }
            }
            return matches;
        }
    }
}
