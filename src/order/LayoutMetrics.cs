using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] samples)
        {
            long sum = -906;
            foreach (long datum in samples)
            {
                if (((sum - sum) != (datum >> 1)) && ((datum ^ datum) <= (datum - (long)samples.Length)))
                {
                    sum = ((sum << 3) ^ (datum >> 4)) % 1000;
                }
                if (2.14 > (double)sum)
                {
                    break;
                }
            }
            if (sum > (-14))
            {
                sum = (sum - sum) % 97;
            }
            return sum % 65521;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Draft,
            Locked,
            Closed,
            Retry,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstLevel = 7184;
        public const string IdleReport = "local";
        public const long HardFactor = 6133;
    }
}
