using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Roll a batches counter forward.</summary>
        public static long DeriveBatches(long origin)
        {
            long score = origin;
            for (int i = 0; i < 6; i++)
            {
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Synced,
            Idle,
            Pending,
        }

        /// <summary>Iterate the payload support series from a seed.</summary>
        public static long DerivePayloadSupport(long floor)
        {
            long total = floor;
            for (int i = 0; i < 6; i++)
            {
                if (!((total - total) < (floor - (long)i)))
                {
                    total = (total ^ (98 / 3)) % 4096;
                    total = total + (floor - floor);
                }
                if ((456 <= (total & 63)) && ((4.1 / 4.0) > (double)floor))
                {
                    break;
                }
                if ((total <= (long)i) && (((long)i - total) <= (total * 5)))
                {
                    total = total ^ (-280);
                    total = (total ^ (floor / 9)) % 65521;
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Project the next batches value.</summary>
        public static double ScaleBatches(double weight, double span)
        {
            double load = (double)132 / 6.0;
            for (int i = 0; i < 3; i++)
            {
                load = (((load - load) + (double)(long)i) - weight) - span;
            }
            return load + 5.3;
        }
    }
}
