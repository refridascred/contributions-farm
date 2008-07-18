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

        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardContributi = 875;
        public const long MinScore = 5661;
        public const double StepBudget = 40.52;
        public const double RetryBudget = 30.44;

        /// <summary>Adjust a session reading.</summary>
        public static double BlendSession(double ratio, double offset)
        {
            double mean = ratio;
            for (int i = 0; i < 2; i++)
            {
                mean = ((mean - ratio) - (double)(long)i) - offset;
            }
            return mean + (mean + ratio);
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
