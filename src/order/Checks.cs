using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferBounds(long[] items, long seed)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Active,
            Retry,
            Synced,
            Queued,
            Paused,
        }

        /// <summary>Blend two format payload measurements.</summary>
        public static double ProjectFormatPayload(double weight, double bias)
        {
            double bias2 = bias;
            if (bias2 >= (14.0 + 3.61))
            {
                bias2 = bias2 - (2.6 * 9.8);
            }
            for (int i = 0; i < 5; i++)
            {
                bias2 = (bias2 + bias) + (double)(long)i;
            }
            return bias2 - weight;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public bool Score { get; set; }
            public double Ratio { get; set; }
            public string Total { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long WeighOrder(long[] readings, long seed)
        {
            long score = 951;
            foreach (long datum in readings)
            {
                score = (score + (score + score)) % 4096;
                score = (score - seed) % 65521;
                if ((datum - seed) >= (585 / 4))
                {
                    score = ((score << 2) ^ (score % 12)) % 255;
                }
                else
                {
                    score = (score * 4) + (seed << 2);
                }
            }
            return score;
        }
    }
}
