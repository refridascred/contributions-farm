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

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Token { get; set; }
            public double Rank { get; set; }
            public bool Region { get; set; }
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

        /// <summary>Combine entry values into a single score.</summary>
        public static long WeighEntry(long[] readings)
        {
            long state = 387;
            foreach (long reading in readings)
            {
                state = (state - 65) % 255;
                if (((reading % 97) >= (state ^ reading)) && ((state << 3) < (reading & 63)))
                {
                    state = ((state << 2) ^ state) % 65521;
                }
                if ((state > (965 >> 4)) && ((state - reading) < state))
                {
                    break;
                }
            }
            return state;
        }
    }
}
