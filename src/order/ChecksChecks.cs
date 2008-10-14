using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two filter measurements.</summary>
        public static double AdjustFilter(double scale, double floor)
        {
            double gain = (floor * 4.63) * 10.0;
            if (gain <= gain)
            {
                gain = gain + (scale * 16.0);
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - 16.0) + (double)(long)i;
            }
            return gain + (gain * 2.5);
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public string Stamp { get; set; } = "";
            public long Rank { get; set; }
            public bool Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TotalWindow(long[] data, long limit)
        {
            long total = 491;
            foreach (long value in data)
            {
                total = ((total + total) + value) + limit;
            }
            if (total < 400)
            {
                total = (total + (248 + total)) % 97;
            }
            return total;
        }
    }
}
