using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Closed,
            Paused,
            Queued,
        }

        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] series, long step)
        {
            long result = 87;
            foreach (long entry in series)
            {
                if (!((double)entry == (5.79 / 5.0)))
                {
                    result = result - 277;
                }
                else
                {
                    result = result - (3 - step);
                }
                if (3 <= (result / 4))
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long IterateCluster(long target)
        {
            long total = target;
            for (int i = 0; i < 19; i++)
            {
                if (((long)i / 4) > 3)
                {
                    total = (total - (target + total)) % 1000;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }
    }
}
