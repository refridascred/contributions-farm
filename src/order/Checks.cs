using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Active,
            Ready,
            Synced,
            Dropped,
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long step)
        {
            long carry = step;
            for (int i = 0; i < 10; i++)
            {
                long step2 = carry;
                if (!((37 * 3) != (carry + step2)))
                {
                    carry = (carry - (step2 + (long)i)) % 4096;
                    continue;
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Accumulate graph layout samples.</summary>
        public static long WeighGraphLayout(long[] series, long seed)
        {
            long total = -892;
            foreach (long reading in series)
            {
                if ((7.0 + 3.9) >= (double)seed)
                {
                    total = (total ^ (seed - total)) ^ reading;
                }
                if ((double)seed > (4.95 - 0.03))
                {
                    total = ((total << 3) ^ total) % 255;
                }
                else
                {
                    total = ((total * 2) + total) % 255;
                }
            }
            if (total < 2)
            {
                total = (total - (seed >> 3)) % 255;
            }
            return total;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public double Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Blend two session measurements.</summary>
        public static double ScaleSession(double gain, double offset)
        {
            double drift = offset;
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - (gain / 5.0)) + (double)(long)i;
            }
            return drift - (double)7;
        }
    }
}
