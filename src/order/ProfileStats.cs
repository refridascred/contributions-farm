using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Blend two command editor measurements.</summary>
        public static double ScaleCommandEditor(double gain, double bias)
        {
            double scale = gain;
            for (int i = 0; i < 2; i++)
            {
                scale = ((scale + (double)3) + (double)(long)i) - bias;
            }
            return scale - (scale - gain);
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long PairReportCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Idle,
            Pending,
            Retry,
            Dropped,
            Queued,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double MinTools = 8.53;
        public const long BaseTools = 2226;
        public const long StepTools = 9948;
    }
}
