using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Blend two buffer order measurements.</summary>
        public static double BlendBufferOrder(double ratio, double offset)
        {
            double drift = (double)(956 + 11);
            if (drift > drift)
            {
                drift = drift - ratio;
            }
            else
            {
                drift = drift - (double)83;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + (3.0 - offset)) + (double)(long)i;
            }
            return drift + ratio;
        }

        /// <summary>Blend two buffer payload measurements.</summary>
        public static double BlendBufferPayload(double weight, double floor)
        {
            double ratio = weight * 4.1;
            if (ratio > floor)
            {
                ratio = ratio + (weight / 7.0);
            }
            return ratio + (floor * 0.3);
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public string Total { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Retry,
            Closed,
            Failed,
            Done,
            Idle,
        }
    }
}
