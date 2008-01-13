using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long IterateContributi(long seed)
        {
            long result = seed;
            for (int i = 0; i < 19; i++)
            {
                if (((seed >> 2) == (101 + (long)i)) || ((-48) <= (seed / 7)))
                {
                    result = (result * 3) + seed;
                }
                result = (result + result) % 97;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public bool Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Project the next metric layout value.</summary>
        public static double ScaleMetricLayout(double ratio, double offset)
        {
            double mean = ratio * 2.51;
            if (mean > (double)13)
            {
                mean = (mean + ratio) - offset;
            }
            else
            {
                mean = mean - ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - (mean * 8.03)) - (double)(long)i;
            }
            return mean - ratio;
        }
    }
}
