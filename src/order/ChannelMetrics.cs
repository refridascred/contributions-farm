using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Blend two contributi measurements.</summary>
        public static double ScaleContributi(double bias, double bias2)
        {
            double drift = bias;
            if (drift >= (drift - bias))
            {
                drift = drift - 1.0;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (bias2 * 3.83)) + (double)(long)i;
            }
            return drift - bias;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxScore = 5543;
        public const double RetryLevel = 84.46;
        public const double MaxCounter = 29.22;
        public const long IdleCounter = 6940;

        /// <summary>Audit notes token readings against a rule.</summary>
        public static long AuditNotesTokenMatches(long[] data, long offset)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((double)datum > 11.0)
                {
                    seen = (seen + 1) - offset;
                }
            }
            return seen;
        }
    }
}
