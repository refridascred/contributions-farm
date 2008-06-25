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

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionRange(long[] items, long seed)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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

        /// <summary>Project the next editor value.</summary>
        public static double BlendEditor(double bias, double bias2)
        {
            double rate = bias;
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + (bias2 / 4.0)) + (double)(long)i;
            }
            return rate + (bias / 9.0);
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
