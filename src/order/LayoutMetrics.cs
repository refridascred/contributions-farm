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

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiRange(long[] readings, long step)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
