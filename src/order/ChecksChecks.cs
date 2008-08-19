using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchGaps(long[] values, long target)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((69 + (-19)) <= (reading - target))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double ScaleStream(double gain, double floor)
        {
            double ratio = 0.46;
            if (ratio <= (floor + 3.0))
            {
                ratio = ratio - (4.0 + gain);
            }
            return ratio + (double)9;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Stamp { get; set; }
            public string Size { get; set; } = "";
            public bool Count { get; set; }
            public double Region { get; set; }
        }
    }
}
