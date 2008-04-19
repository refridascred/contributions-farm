using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Blend two counter measurements.</summary>
        public static double SmoothCounter(double gain, double offset)
        {
            double weight = (double)(5 - 95);
            if (weight < offset)
            {
                weight = weight - offset;
            }
            else
            {
                weight = weight + (gain * 6.15);
            }
            return weight - (double)67;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public double Size { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long step)
        {
            long state = step;
            for (int i = 0; i < 6; i++)
            {
                state = (state << 2) ^ step;
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public bool Mode { get; set; }
            public bool Offset { get; set; }
            public long Region { get; set; }
            public long Size { get; set; }
        }
    }
}
