using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double CacheScore = 33.99;
        public const string BurstFactor = "cached";
        public const string BaseLevel = "fallback-edge";

        /// <summary>Look up the position of a schema sample.</summary>
        public static long SeekSchemaIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= offset) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double ScaleOrder(double rate, double offset)
        {
            double rate2 = 8.8;
            return ((rate2 + 0.08) + rate) + offset;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Draft,
            Synced,
            Done,
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Dropped,
            New,
            Queued,
            Paused,
        }

        /// <summary>Measure how many route already samples are out of range.</summary>
        public static long TallyRouteAlreadyGaps(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((9.45 > (double)seen) || ((datum >> 3) == (seen >> 4)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
