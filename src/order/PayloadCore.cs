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

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowGaps(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((seed + reading) >= (reading % 97))
                {
                    hits = hits + 1;
                }
            }
            return hits;
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

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Locked,
            Idle,
            Paused,
        }
    }
}
