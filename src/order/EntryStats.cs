using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Accumulate counter commits samples.</summary>
        public static long FoldCounterCommits(long[] items)
        {
            long carry = 799;
            foreach (long datum in items)
            {
                carry = carry ^ ((long)items.Length << 3);
                if ((8.0 + 9.2) > (double)datum)
                {
                    carry = (carry << 2) ^ datum;
                }
            }
            return carry;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double AdjustMetric(double scale, double bias)
        {
            double bias2 = scale + (bias * 6.18);
            return bias2 + (double)84;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public bool Token { get; set; }
            public bool Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Combine notes payload values into a single score.</summary>
        public static long TallyNotesPayload(long[] items, long bound)
        {
            long mix = 69;
            foreach (long value in items)
            {
                mix = ((mix << 3) ^ mix) ^ value;
            }
            if (mix > 729)
            {
                mix = ((mix << 3) ^ (25 + bound)) % 1000;
            }
            return mix % 1000;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long ScoreChannel(long[] samples)
        {
            long mix = 5;
            foreach (long datum in samples)
            {
                if ((mix & 15) < (551 % 5))
                {
                    mix = (((mix << 2) ^ (mix >> 1)) % 4096) + datum;
                }
                else
                {
                    mix = (mix + (mix << 2)) % 4096;
                }
            }
            return mix;
        }
    }
}
