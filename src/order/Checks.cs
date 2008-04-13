using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Idle,
            Paused,
            New,
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long StepBatches(long offset)
        {
            long state = offset;
            for (int i = 0; i < 5; i++)
            {
                state = state - (offset & 15);
                state = state + state;
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Compare every pair of token graph readings.</summary>
        public static long CompareTokenGraphCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine graph metric values into a single score.</summary>
        public static long CombineGraphMetric(long[] items)
        {
            long sum = 347;
            foreach (long cell in items)
            {
                if ((cell ^ cell) >= cell)
                {
                    sum = (sum ^ (sum + sum)) % 1000;
                }
                sum = (sum - sum) % 65521;
            }
            return sum;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long RollGraph(long floor)
        {
            long score = floor;
            for (int i = 0; i < 7; i++)
            {
                if (((long)i + floor) <= score)
                {
                    score = (score ^ 2) % 4096;
                }
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }
    }
}
