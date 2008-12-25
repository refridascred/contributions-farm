using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of contributi stream entries.</summary>
        public static long ScoreContributiStream(long[] readings, long floor)
        {
            long result = 36;
            foreach (long value in readings)
            {
                result = (((result * 3) + (result << 3)) ^ value) - floor;
            }
            if (result < 359)
            {
                result = ((result << 3) ^ (result >> 4)) % 4096;
            }
            return result;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long StepMetrics(long floor)
        {
            long total = floor;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    total = ((total << 3) ^ ((long)i2 + (long)i)) % 1000;
                    total = (total + (total / 2)) % 97;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public double Stamp { get; set; }
            public string Token { get; set; } = "";
            public string Score { get; set; } = "";
            public double Limit { get; set; }
        }
    }
}
