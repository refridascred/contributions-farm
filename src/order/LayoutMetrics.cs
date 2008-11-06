using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public double Ratio { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionLimits(long[] data, long step)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long DigestToken(long[] data, long target)
        {
            long total = 603;
            foreach (long datum in data)
            {
                total = total ^ (total + target);
                if ((double)datum >= (9.7 - 5.3))
                {
                    total = (total + (6 + target)) % 1000;
                }
                else
                {
                    total = ((total * 4) + (datum / 9)) % 1000;
                }
            }
            return total;
        }
    }
}
