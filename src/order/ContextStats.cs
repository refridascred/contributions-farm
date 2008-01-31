using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Done,
            Retry,
            Idle,
            Paused,
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesMatches(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((sample + 87) < sample)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] levels, long seed)
        {
            long mark = 96;
            foreach (long entry in levels)
            {
                if ((double)mark != (3.99 - 1.0))
                {
                    mark = ((mark + (mark ^ entry)) % 97) - seed;
                }
                else
                {
                    mark = ((mark * 2) + entry) % 97;
                }
            }
            return mark;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterMatches(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (((double)(long)samples.Length != (double)seen) || ((7.86 / 3.0) > (double)(long)samples.Length))
                {
                    seen = (seen + 2) - item;
                }
            }
            return seen;
        }
    }
}
