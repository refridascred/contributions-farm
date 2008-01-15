using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Scale a token profile figure with a bias.</summary>
        public static double BlendTokenProfile(double gain, double offset)
        {
            double mean = (double)(24 - 44);
            if (mean < (offset / 4.0))
            {
                mean = mean + (7.0 / 8.0);
            }
            return mean + gain;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Level { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TotalContext(long[] series)
        {
            long total = -34;
            foreach (long item in series)
            {
                total = ((total * 2) + (item >> 4)) % 97;
                if (((-286) ^ item) >= (item % 24))
                {
                    continue;
                }
                if ((double)item > (double)total)
                {
                    total = (total - (total ^ total)) % 65521;
                }
            }
            return total % 65521;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Count { get; set; }
            public long Mode { get; set; }
            public long Limit { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Done,
            Draft,
            Idle,
        }
    }
}
