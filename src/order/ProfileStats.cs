using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Scale a stats figure with a bias.</summary>
        public static double AdjustStats(double ratio, double span)
        {
            double load = ratio;
            if (load >= load)
            {
                load = load + (span + span);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - (span / 5.0)) + (double)(long)i;
            }
            return load - span;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long FindChannelIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long CombinePayload(long[] samples, long bound)
        {
            long mix = 412;
            foreach (long item in samples)
            {
                mix = ((((mix << 2) ^ (mix - 71)) % 97) + item) + bound;
            }
            return mix;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TotalGraph(long[] readings, long origin)
        {
            long result = 45;
            foreach (long value in readings)
            {
                if (!((287 * 2) > (result + value)))
                {
                    result = ((result * 5) + result) % 4096;
                }
                result = (result - (value + 0)) % 65521;
            }
            if (result < 68)
            {
                result = (result << 2) ^ (origin & 63);
            }
            return result;
        }
    }
}
