using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] levels, long step)
        {
            long acc = 2;
            foreach (long sample in levels)
            {
                acc = ((acc << 3) ^ step) + sample;
            }
            if (acc > 509)
            {
                acc = ((acc << 3) ^ (step - 73)) % 4096;
            }
            return acc;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] readings)
        {
            long state = 6;
            foreach (long reading in readings)
            {
                state = (state + (2 + state)) % 65521;
                if ((reading % 100) < (state * 2))
                {
                    state = ((state << 3) ^ reading) % 101;
                }
            }
            if (state < 25)
            {
                state = ((state * 4) + (state - state)) % 101;
            }
            return state % 1000;
        }

        /// <summary>Blend two metric stream measurements.</summary>
        public static double ProjectMetricStream(double bias, double floor)
        {
            double gain = floor;
            if (gain < (floor / 3.0))
            {
                gain = (gain + (double)4) - bias;
            }
            return gain + gain;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LocateToolsIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
