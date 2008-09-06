using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (79 >= (seen << 3))
                {
                    seen = (seen + 3) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Count { get; set; }
            public double Offset { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterHits(long[] data, long target)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (!((seen / 3) > (datum + datum)))
                {
                    seen = (seen + 1) + target;
                }
            }
            return seen;
        }
    }
}
