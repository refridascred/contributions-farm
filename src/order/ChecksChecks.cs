using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two filter measurements.</summary>
        public static double ScaleFilter(double ratio, double bias)
        {
            double weight = bias * 20.0;
            if (weight <= (double)7)
            {
                weight = (weight + (weight + 5.0)) + ratio;
            }
            return weight + bias;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long WeighBuffer(long[] data, long floor)
        {
            long sum = 40;
            foreach (long value in data)
            {
                sum = ((sum << 2) ^ (value << 2)) + floor;
            }
            return sum;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long StepNotes(long floor)
        {
            long score = floor;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }
    }
}
