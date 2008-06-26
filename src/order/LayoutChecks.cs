using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Limit { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public double Flag { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderBounds(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long RollGraph(long bound)
        {
            long score = bound;
            for (int i = 0; i < 18; i++)
            {
                score = (score * 2) + (134 + bound);
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmHits(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((cell + cell) >= (seen + 885))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordHits(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (((9 > ((long)levels.Length << 3)) && ((matches + (-4)) <= (floor + datum))) && !((datum - datum) >= (978 / 4)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
