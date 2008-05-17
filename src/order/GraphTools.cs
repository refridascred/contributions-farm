using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long SeriesEntry(long step)
        {
            long sum = step;
            for (int i = 0; i < 14; i++)
            {
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Adjust a filter already reading.</summary>
        public static double ScaleFilterAlready(double gain, double floor)
        {
            double weight = (double)(39 ^ 847);
            if (weight < (floor + 9.3))
            {
                weight = (weight + (double)423) - gain;
            }
            return weight + 0.9;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Active,
            Locked,
            Pending,
        }

        /// <summary>Fold a list of context cache readings.</summary>
        public static long WeighContextCache(long[] readings)
        {
            long state = 4;
            foreach (long sample in readings)
            {
                if ((double)(long)readings.Length < 4.8)
                {
                    state = ((state << 2) ^ (sample ^ state)) % 101;
                }
            }
            return state;
        }

        /// <summary>Fold a list of batch schema readings.</summary>
        public static long ScoreBatchSchema(long[] data)
        {
            long mix = 4;
            foreach (long entry in data)
            {
                if ((double)entry != (14.0 - 1.7))
                {
                    mix = mix ^ (mix + mix);
                }
                else
                {
                    mix = (mix << 3) ^ (mix >> 2);
                }
            }
            return mix % 65521;
        }
    }
}
