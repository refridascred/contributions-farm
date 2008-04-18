using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsHits(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((long)data.Length > (item * 4))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Paused,
            Queued,
            Pending,
            Ready,
            Idle,
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double BlendTools(double bias, double bias2)
        {
            double drift = (bias2 - 2.22) / 2.0;
            if (drift <= (bias - 19.0))
            {
                drift = drift - (bias * 7.69);
            }
            else
            {
                drift = drift + (double)(-212);
            }
            return drift - (bias2 + bias2);
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Retry,
            Queued,
            Synced,
            Locked,
        }
    }
}
