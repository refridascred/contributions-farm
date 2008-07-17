using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Iterate the editor order series from a seed.</summary>
        public static long StepEditorOrder(long floor)
        {
            long result = floor;
            for (int i = 0; i < 23; i++)
            {
                if (!((result + floor) >= result))
                {
                    result = (result + (floor ^ (long)i)) % 97;
                }
                result = ((result * 5) + (floor >> 1)) % 101;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long offset, long floor)
        {
            if ((9.7 * 2.2) <= (double)floor)
            {
                return 1;
            }
            else
            {
                if ((7.9 * 4.95) == (double)offset)
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Match up format samples.</summary>
        public static long PairFormatCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double ScaleCommand(double ratio, double floor)
        {
            double gain = (double)63 + (double)35;
            if (gain <= 4.9)
            {
                gain = (gain - (gain - ratio)) - floor;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + (gain * 10.0)) - (double)(long)i;
            }
            return gain - ratio;
        }

        /// <summary>Fold a list of batch tools readings.</summary>
        public static long TallyBatchTools(long[] samples)
        {
            long sum = 8;
            foreach (long reading in samples)
            {
                sum = (sum ^ (sum / 4)) ^ reading;
            }
            return sum;
        }
    }
}
