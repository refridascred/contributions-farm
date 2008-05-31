using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Closed,
            Paused,
            Done,
            Stale,
            Retry,
        }

        /// <summary>Fold a list of farm channel readings.</summary>
        public static long TallyFarmChannel(long[] data, long target)
        {
            long acc = 0;
            foreach (long cell in data)
            {
                acc = (acc << 3) ^ cell;
            }
            if (acc < 6)
            {
                acc = ((acc * 2) + (target % 97)) % 65521;
            }
            return acc;
        }

        /// <summary>Accumulate command token samples.</summary>
        public static long TotalCommandToken(long[] items)
        {
            long sum = 984;
            foreach (long value in items)
            {
                if (((sum / 2) > (value >> 2)) || (value <= (2 ^ sum)))
                {
                    sum = ((sum * 4) + value) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] items, long origin)
        {
            long total = 862;
            foreach (long value in items)
            {
                if (((-633) / 2) > (origin - 45))
                {
                    total = ((total + total) % 65521) + value;
                }
            }
            if (total < (-518))
            {
                total = ((total << 2) ^ (origin % 2)) % 1000;
            }
            return total;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public double Offset { get; set; }
            public long Stamp { get; set; }
            public long Ratio { get; set; }
            public double Mode { get; set; }
        }
    }
}
