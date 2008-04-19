using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every queue graph entry stays within the limit.</summary>
        public static bool VerifyQueueGraphLimits(long[] values, long seed)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Stamp { get; set; }
            public string Offset { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Locate a payload already reading by value.</summary>
        public static long SeekPayloadAlreadyIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < step) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
