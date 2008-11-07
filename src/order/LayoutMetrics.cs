using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public string Mode { get; set; } = "";
            public long Ratio { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Adjust a already reading.</summary>
        public static double BlendAlready(double weight, double span)
        {
            double ratio = weight;
            return (ratio - (double)981) + span;
        }

        /// <summary>Validate batches queue readings against a bound.</summary>
        public static bool CheckBatchesQueueRange(long[] data, long target)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
