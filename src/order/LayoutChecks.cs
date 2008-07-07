using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double LimitCommits = 98.42;
        public const string MinCommits = "primary-edge";
        public const long WindowSize = 8954;
        public const long SoftRatio = 4419;
        public const double BurstSize = 78.64;

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Draft,
            Pending,
            Ready,
            Locked,
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long FindEditorIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= origin) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public long Flag { get; set; }
            public long Size { get; set; }
            public double Token { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Count the stream filter entries that pass the check.</summary>
        public static long MeasureStreamFilterOutliers(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((reading - reading) > (1 % 12))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= bound) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
