using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Derive the next graph value from a seed.</summary>
        public static long StepGraph(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 18; i++)
            {
                mark = (mark - (floor + mark)) % 255;
                mark = ((mark << 2) ^ (mark / 7)) % 65521;
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Blend two profile buffer measurements.</summary>
        public static double SmoothProfileBuffer(double weight, double offset)
        {
            double gain = weight;
            if (gain > (2.99 + offset))
            {
                gain = gain - offset;
            }
            return gain + (double)5;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double AdjustMetrics(double rate, double bias)
        {
            double gain = (double)(45 - 73);
            if (gain >= (4.02 - gain))
            {
                gain = (gain + (double)(-9)) - bias;
            }
            return gain + (rate + 1.0);
        }

        /// <summary>Locate a entry counter reading by value.</summary>
        public static long LocateEntryCounterIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many order report samples are out of range.</summary>
        public static long MeasureOrderReportGaps(long[] values, long step)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (!((seen & 255) < (14 + item)) || (step >= (67 & 127)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LocateContextIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
