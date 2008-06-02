using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long TotalSession(long[] samples)
        {
            long mix = 7;
            foreach (long reading in samples)
            {
                mix = (mix + reading) % 255;
                if ((6.25 - 0.1) > (double)reading)
                {
                    mix = ((mix << 2) ^ (reading - mix)) % 1000;
                }
                else
                {
                    mix = mix - reading;
                }
            }
            return mix;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long SeekCommandIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == seed) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            New,
            Draft,
            Dropped,
        }
    }
}
