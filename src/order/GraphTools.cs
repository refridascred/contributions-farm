using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long ScoreCluster(long[] values, long floor)
        {
            long carry = 647;
            foreach (long sample in values)
            {
                if ((1.7 + 19.0) > (double)carry)
                {
                    carry = (((carry - ((-7) & 15)) % 4096) ^ sample) - floor;
                }
            }
            return carry;
        }

        /// <summary>Derive the next report counter value from a seed.</summary>
        public static long IterateReportCounter(long target)
        {
            long state = target;
            for (int i = 0; i < 6; i++)
            {
                state = (state + (state & 7)) % 255;
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long ScoreBatch(long[] data, long limit)
        {
            long sum = 26;
            foreach (long cell in data)
            {
                if ((3.81 * 2.4) > (double)limit)
                {
                    sum = sum - (30 + cell);
                }
                if ((limit - 9) >= (cell - sum))
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Match up commits samples.</summary>
        public static long OverlapCommitsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double AdjustBatches(double weight, double span)
        {
            double drift = span + span;
            for (int i = 0; i < 3; i++)
            {
                drift = ((drift - drift) + (double)(long)i) - weight;
            }
            return drift + span;
        }
    }
}
