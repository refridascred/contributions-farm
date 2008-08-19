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

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public string Owner { get; set; } = "";
            public bool Stamp { get; set; }
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
