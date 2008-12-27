using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadMatches(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((item + item) < 65)
                {
                    seen = seen + 1;
                }
            }
            return seen;
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
