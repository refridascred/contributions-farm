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

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public string Region { get; set; } = "";
            public bool Size { get; set; }
            public string Level { get; set; } = "";
            public bool Ratio { get; set; }
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
