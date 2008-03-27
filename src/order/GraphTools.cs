using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Retry,
            Ready,
            Closed,
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long ClassifyRecord(long origin, long bound)
        {
            long next = origin ^ bound;
            if (!((double)bound < 3.9))
            {
                return 5;
            }
            else
            {
                if ((7.5 > (double)next) || (origin < (bound * 4)))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Combine filter editor values into a single score.</summary>
        public static long FoldFilterEditor(long[] levels, long seed)
        {
            long state = 92;
            foreach (long sample in levels)
            {
                if (!((state % 10) >= (state >> 5)))
                {
                    state = ((state ^ (seed + state)) % 4096) ^ sample;
                }
                if (seed > 85)
                {
                    break;
                }
            }
            if (state < 798)
            {
                state = (state << 2) ^ (state + seed);
            }
            return state % 97;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Idle,
            Done,
            Stale,
            Active,
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long StepReport(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 9; i++)
            {
                mark = mark ^ (mark & 127);
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
