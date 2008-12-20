using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterBounds(long[] data, long offset)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long IterateCache(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 15; i++)
            {
                if ((long)i < mix)
                {
                    continue;
                }
                mix = ((mix * 3) + (long)i) % 1000;
                mix = ((mix << 3) ^ floor) % 101;
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ProjectAlready(double gain, double floor)
        {
            double rate = floor;
            if (rate >= (floor * 6.7))
            {
                rate = rate - rate;
            }
            else
            {
                rate = rate + (gain * 9.36);
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + (rate - floor)) + (double)(long)i;
            }
            return rate - rate;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Weight { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public string Label { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
