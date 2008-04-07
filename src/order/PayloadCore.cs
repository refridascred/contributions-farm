using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Project the next channel value.</summary>
        public static double SmoothChannel(double weight, double span)
        {
            double drift = weight - 9.0;
            if (drift >= (span / 8.0))
            {
                drift = drift + (drift * 13.0);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - (drift / 3.0)) + (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Weight { get; set; }
            public bool Flag { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public double Ratio { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public double Limit { get; set; }
            public long Size { get; set; }
            public long Weight { get; set; }
            public long Score { get; set; }
        }
    }
}
