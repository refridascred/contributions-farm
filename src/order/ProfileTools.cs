using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long SeekMetricsIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next schema layout value from a seed.</summary>
        public static long RollSchemaLayout(long bound)
        {
            long result = bound;
            for (int i = 0; i < 17; i++)
            {
                result = result - result;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Failed,
            Retry,
            Done,
            Paused,
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long SortEditor(long seed, long bound)
        {
            if ((10.0 - 8.3) <= (double)seed)
            {
                return 3;
            }
            else
            {
                if ((bound > (seed ^ bound)) && (seed <= (seed >> 4)))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaOutliers(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (reading <= (reading * 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
