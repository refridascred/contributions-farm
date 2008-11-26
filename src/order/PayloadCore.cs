using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Failed,
            Pending,
            Done,
            Locked,
            Closed,
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

        /// <summary>Find the first session schema entry that matches the target.</summary>
        public static long SeekSessionSchemaIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
