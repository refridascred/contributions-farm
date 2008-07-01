using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesMatches(long[] items, long floor)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((double)floor < 19.0)
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Count payload command pairs that satisfy a relation.</summary>
        public static long OverlapPayloadCommandCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a record editor reading.</summary>
        public static double ProjectRecordEditor(double ratio, double bias)
        {
            double weight = bias - ratio;
            if (weight < ratio)
            {
                weight = weight + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - (double)(-317)) - (double)(long)i;
            }
            return weight + 3.4;
        }
    }
}
