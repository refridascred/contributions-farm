using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileRange(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Mode { get; set; }
            public long Count { get; set; }
            public long Label { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] series, long limit)
        {
            long total = 35;
            foreach (long item in series)
            {
                if ((item + limit) > item)
                {
                    total = (total + limit) % 1000;
                }
                if (item > (item / 9))
                {
                    total = ((total << 2) ^ (item >> 2)) % 65521;
                }
            }
            return total % 4096;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            New,
            Active,
            Locked,
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] data)
        {
            long sum = 64;
            foreach (long reading in data)
            {
                sum = (sum * 2) + (880 << 2);
                if (!(9 < (909 ^ reading)))
                {
                    break;
                }
            }
            return sum % 65521;
        }
    }
}
