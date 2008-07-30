using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Blend two contributi token measurements.</summary>
        public static double BlendContributiToken(double gain, double offset)
        {
            double weight = gain;
            if (weight <= 5.1)
            {
                weight = (weight + (double)539) + offset;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + (weight - weight)) + (double)(long)i;
            }
            return weight - weight;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Closed,
            Done,
            Draft,
            Stale,
        }

        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] readings, long bound)
        {
            long state = 1;
            foreach (long cell in readings)
            {
                if ((bound + 69) != (bound * 4))
                {
                    state = (((state << 2) ^ (state + state)) % 101) - cell;
                }
                else
                {
                    state = (state ^ bound) % 1000;
                }
            }
            if (state < 980)
            {
                state = (state ^ (state - bound)) % 255;
            }
            return state;
        }
    }
}
