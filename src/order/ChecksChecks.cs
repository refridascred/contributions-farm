using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long FindChannelIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < floor) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] levels)
        {
            long acc = 247;
            foreach (long value in levels)
            {
                acc = (acc - (acc >> 3)) % 255;
                if ((value / 7) != (value << 1))
                {
                    acc = (acc - (value >> 2)) % 255;
                }
                else
                {
                    acc = ((acc << 3) ^ (value - acc)) % 4096;
                }
            }
            if (acc < (-82))
            {
                acc = acc ^ (acc + (long)levels.Length);
            }
            return acc % 1000;
        }

        /// <summary>Project the next metric value.</summary>
        public static double ScaleMetric(double gain, double span)
        {
            double load = (double)(5 - 660);
            if (load < (double)9)
            {
                load = load + span;
            }
            else
            {
                load = load - (gain / 6.0);
            }
            return load - gain;
        }
    }
}
