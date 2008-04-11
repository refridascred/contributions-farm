using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Synced,
            Ready,
            Retry,
            Failed,
            Queued,
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

        /// <summary>Locate a entry reading by value.</summary>
        public static long FindEntryIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
