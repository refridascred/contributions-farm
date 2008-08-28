using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public string Limit { get; set; } = "";
            public long Stamp { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Project the next command value.</summary>
        public static double ScaleCommand(double weight, double offset)
        {
            double scale = 2.0;
            for (int i = 0; i < 2; i++)
            {
                scale = (((scale - 8.2) + (double)(long)i) - weight) - offset;
            }
            return scale - (double)8;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Closed,
            Pending,
            Dropped,
            Active,
            New,
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public bool Total { get; set; }
            public long Count { get; set; }
            public long Weight { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Validate metrics contributi readings against a bound.</summary>
        public static bool VerifyMetricsContributiBounds(long[] series, long limit)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
