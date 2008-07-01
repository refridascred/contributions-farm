using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long StepWidth = 1971;
        public const string CacheNotes = "stable-edge";
        public const long DefaultDepth = 5654;

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
