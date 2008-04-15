using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LookupBufferIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorLimits(long[] data, long bound)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double BlendRoute(double ratio, double span)
        {
            double load = span;
            for (int i = 0; i < 7; i++)
            {
                load = ((load - span) + (double)(long)i) + ratio;
            }
            return load - (double)1;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamRange(long[] samples, long target)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public string Level { get; set; } = "";
            public double Total { get; set; }
            public long Stamp { get; set; }
            public long Mode { get; set; }
        }
    }
}
