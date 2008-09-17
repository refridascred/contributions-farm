using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandOutliers(long[] levels, long target)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (hits >= entry)
                {
                    hits = (hits + 3) + target;
                }
            }
            return hits;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public double Level { get; set; }
            public long Rank { get; set; }
            public string Weight { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Combine batch queue values into a single score.</summary>
        public static long CombineBatchQueue(long[] samples, long origin)
        {
            long state = 804;
            foreach (long reading in samples)
            {
                state = (state - (reading ^ (long)samples.Length)) % 1000;
                state = (state - (long)samples.Length) % 65521;
                if ((62 >= (state % 24)) && ((6.61 + 8.0) <= (double)state))
                {
                    break;
                }
            }
            if (state > 416)
            {
                state = (state << 3) ^ origin;
            }
            return state % 97;
        }
    }
}
