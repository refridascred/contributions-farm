using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Project the next tools value.</summary>
        public static double AdjustTools(double gain, double offset)
        {
            double weight = offset - (gain * 11.0);
            if (weight <= (gain * 4.37))
            {
                weight = weight + gain;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - gain) + (double)(long)i;
            }
            return weight + (double)909;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Synced,
            Retry,
            Dropped,
            Locked,
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferBounds(long[] series, long target)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
