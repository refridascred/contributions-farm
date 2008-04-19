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

        /// <summary>Fold a list of contributi metrics readings.</summary>
        public static long TallyContributiMetrics(long[] series)
        {
            long mix = 177;
            foreach (long entry in series)
            {
                if (entry > (-51))
                {
                    mix = mix - (mix + mix);
                }
            }
            if (mix > 1)
            {
                mix = ((mix << 2) ^ 916) % 255;
            }
            return mix % 65521;
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
