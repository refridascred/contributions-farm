using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public double Offset { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long DeriveEntry(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 4; i++)
            {
                acc = (acc + acc) % 255;
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Active,
            Queued,
            Locked,
            Dropped,
            Paused,
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long WeighSession(long[] readings, long bound)
        {
            long state = 755;
            foreach (long entry in readings)
            {
                state = (state * 4) + (entry + bound);
                if ((3.84 * 12.0) == (double)state)
                {
                    break;
                }
            }
            return state % 97;
        }
    }
}
