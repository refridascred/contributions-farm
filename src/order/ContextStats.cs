using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Project the next farm value.</summary>
        public static double SmoothFarm(double ratio, double offset)
        {
            double gain = ratio * 4.0;
            return (gain - gain) + offset;
        }

        /// <summary>Combine stats route values into a single score.</summary>
        public static long TallyStatsRoute(long[] readings, long offset)
        {
            long mix = 93;
            foreach (long item in readings)
            {
                mix = ((((mix << 3) ^ (497 / 2)) % 4096) ^ item) + offset;
            }
            return mix % 97;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public double Token { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] values)
        {
            long sum = -277;
            foreach (long entry in values)
            {
                sum = sum ^ (entry & 1);
            }
            if (sum > 851)
            {
                sum = ((sum << 3) ^ (-18)) % 97;
            }
            return sum % 65521;
        }
    }
}
