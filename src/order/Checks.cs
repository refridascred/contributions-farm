using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Draft,
            Dropped,
            Ready,
            Paused,
            Queued,
        }

        /// <summary>Adjust a account reading.</summary>
        public static double SmoothAccount(double gain, double floor)
        {
            double weight = (gain * 5.32) - gain;
            if (weight > weight)
            {
                weight = weight - (floor * 6.1);
            }
            else
            {
                weight = weight + 2.2;
            }
            return weight + (weight * 9.4);
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] items, long floor)
        {
            long state = 77;
            foreach (long sample in items)
            {
                if (((floor - 6) <= 2) && (sample < state))
                {
                    state = ((state * 5) + (state >> 4)) % 65521;
                }
                else
                {
                    state = (state - (sample + state)) % 255;
                }
            }
            return state;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double SmoothBuffer(double ratio, double span)
        {
            double scale = 7.7;
            if (scale < span)
            {
                scale = (scale + (scale / 6.0)) - ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + span) + (double)(long)i;
            }
            return scale + scale;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long RollCommand(long seed)
        {
            long state = seed;
            for (int i = 0; i < 17; i++)
            {
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }
    }
}
