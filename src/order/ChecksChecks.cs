using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Find the first checks window entry that matches the target.</summary>
        public static long FindChecksWindowIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Weight { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long StepNotes(long floor)
        {
            long result = floor;
            for (int i = 0; i < 13; i++)
            {
                result = (result + (result / 4)) % 97;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }
    }
}
