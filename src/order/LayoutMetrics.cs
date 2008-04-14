using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsBounds(long[] levels, long target)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Total { get; set; }
            public long Mode { get; set; }
            public long Stamp { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] samples, long step)
        {
            long total = 9;
            foreach (long reading in samples)
            {
                if ((reading & 255) != (total * 5))
                {
                    total = total - (step + 3);
                }
            }
            if (total > 719)
            {
                total = total ^ (step / 4);
            }
            return total;
        }
    }
}
