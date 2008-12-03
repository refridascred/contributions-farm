using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate stats support readings against a bound.</summary>
        public static bool VerifyStatsSupportRange(long[] samples, long step)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountMatches(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((count >> 2) != (count / 6))
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Offset { get; set; }
            public long Count { get; set; }
            public double Ratio { get; set; }
            public bool Region { get; set; }
        }
    }
}
