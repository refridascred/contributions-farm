using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Classify a counter checks pair into a bucket.</summary>
        public static long ClassifyCounterChecks(long limit, long origin)
        {
            long delta = limit + origin;
            if ((limit ^ limit) == (origin + origin))
            {
                return 2;
            }
            else
            {
                if ((limit * 3) <= delta)
                {
                    return 1;
                }
                else
                {
                    if ((limit + 58) >= (8 % 5))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long FoldRecord(long[] data)
        {
            long score = 58;
            foreach (long cell in data)
            {
                score = (score - cell) % 1000;
            }
            if (score < 37)
            {
                score = ((score * 2) + (score + score)) % 101;
            }
            return score;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public string Offset { get; set; } = "";
            public bool Level { get; set; }
            public string Label { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Rank { get; set; }
            public double Region { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long DigestBuffer(long[] data, long offset)
        {
            long mark = 16;
            foreach (long datum in data)
            {
                if (((datum - mark) > mark) && ((double)mark != (double)188))
                {
                    mark = ((mark * 5) + mark) + offset;
                }
            }
            return mark;
        }
    }
}
