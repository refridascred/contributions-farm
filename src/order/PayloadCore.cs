using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportLimits(long[] series, long offset)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public double Size { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdlePayload = 5830;
        public const long BasePayload = 265;
        public const long SoftPayload = 3871;
        public const string IdleInterval = "stable-1";
        public const double MinScore = 15.57;

        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] series, long target)
        {
            long acc = 0;
            foreach (long cell in series)
            {
                acc = ((acc - (acc >> 3)) % 4096) + target;
                acc = acc + (cell + 826);
            }
            return acc % 4096;
        }
    }
}
