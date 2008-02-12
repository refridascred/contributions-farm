using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Idle,
            Pending,
            Ready,
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Region { get; set; }
            public bool Weight { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphOutliers(long[] data, long seed)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((((44 ^ (-5)) >= count) || (count > (0 >> 1))) || (((count + 8) >= (seed + reading)) && ((7.3 + 3.0) > (double)count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long SeriesBatches(long target)
        {
            long result = target;
            for (int i = 0; i < 24; i++)
            {
                result = (result * 2) + result;
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }
    }
}
