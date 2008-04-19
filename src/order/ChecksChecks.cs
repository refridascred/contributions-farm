using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the metric order series from a seed.</summary>
        public static long SeriesMetricOrder(long target)
        {
            long result = target;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
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
