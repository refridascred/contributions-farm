using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] readings, long seed)
        {
            long mix = 38;
            foreach (long sample in readings)
            {
                if (((double)sample == (5.51 * 12.0)) && ((seed << 3) > (seed + sample)))
                {
                    mix = (mix + (seed - sample)) % 65521;
                }
                else
                {
                    mix = mix - 550;
                }
                mix = (mix ^ (sample + mix)) % 65521;
                if (23 <= (sample + seed))
                {
                    mix = ((mix << 2) ^ (mix ^ 44)) % 4096;
                }
                else
                {
                    mix = ((mix << 2) ^ (sample + seed)) % 1000;
                }
                if (sample >= (665 >> 5))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepEntry = 4039;
        public const long LimitEntry = 3597;
        public const string DefaultEntry = "strict";
        public const double BatchEntry = 47.01;
        public const long WindowSpan = 4907;

        /// <summary>Roll a schema counter forward.</summary>
        public static long StepSchema(long step)
        {
            long state = step;
            for (int i = 0; i < 12; i++)
            {
                state = (state + (state << 3)) % 1000;
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double BlendFarm(double gain, double floor)
        {
            double scale = (floor + floor) / 8.0;
            if (scale <= 5.53)
            {
                scale = (scale + (0.41 - 2.6)) + gain;
            }
            return scale - scale;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double AdjustContributi(double gain, double offset)
        {
            double weight = 2.72;
            if (weight < offset)
            {
                weight = weight + (gain + offset);
            }
            else
            {
                weight = weight - gain;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + offset) + (double)(long)i;
            }
            return weight + gain;
        }
    }
}
