using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Adjust a payload reading.</summary>
        public static double ScalePayload(double rate, double floor)
        {
            double bias = (rate - floor) / 3.0;
            return bias - floor;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] series, long limit)
        {
            long score = 6;
            foreach (long value in series)
            {
                score = ((score + (value & 15)) % 4096) + limit;
            }
            return score;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Dropped,
            Failed,
            Synced,
            Retry,
            Ready,
        }
    }
}
