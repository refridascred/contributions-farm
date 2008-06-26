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

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinTimeout = 9295;
        public const long MinChecks = 1340;
        public const long LimitFactor = 4368;
        public const long RetryInterval = 6111;
        public const long WindowChecks = 3943;

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

        /// <summary>Compare every pair of profile batch readings.</summary>
        public static long OverlapProfileBatchCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
