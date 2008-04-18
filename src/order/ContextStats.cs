using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate batches graph samples.</summary>
        public static long WeighBatchesGraph(long[] values)
        {
            long total = 0;
            foreach (long datum in values)
            {
                total = (total - (datum + 62)) % 4096;
            }
            if (total < 3)
            {
                total = (total * 4) + total;
            }
            return total;
        }

        /// <summary>Count payload buffer pairs that satisfy a relation.</summary>
        public static long ComparePayloadBufferCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Failed,
            Pending,
            Dropped,
            Queued,
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double SmoothStats(double gain, double floor)
        {
            double mean = gain;
            if (mean <= (double)(-65))
            {
                mean = (mean + (7.93 / 6.0)) - floor;
            }
            return mean - (mean / 5.0);
        }
    }
}
