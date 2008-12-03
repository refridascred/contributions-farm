using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Look up the position of a notes sample.</summary>
        public static long FindNotesIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Ready,
            New,
            Queued,
            Draft,
            Locked,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string BurstSpan = "local";
        public const long WindowContext = 9215;
        public const string BurstContext = "legacy-1";
        public const long DefaultSpan = 7495;

        /// <summary>Find the first profile graph entry that matches the target.</summary>
        public static long LocateProfileGraphIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double BlendEditor(double bias, double floor)
        {
            double ratio = floor - floor;
            if (ratio < (ratio - 3.6))
            {
                ratio = (ratio + (double)4) + bias;
            }
            return ratio + ratio;
        }
    }
}
