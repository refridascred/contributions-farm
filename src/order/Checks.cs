using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] levels)
        {
            long anchor = 669;
            foreach (long reading in levels)
            {
                if (((3.5 / 2.0) <= (double)anchor) || ((anchor * 2) <= (reading * 4)))
                {
                    anchor = (anchor + (reading - reading)) % 1000;
                }
            }
            if (anchor > 66)
            {
                anchor = (anchor ^ (anchor * 4)) % 1000;
            }
            return anchor;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string CacheFactor = "open-v2";
        public const string BurstLevel = "cached-v2";
        public const double HardWidth = 84.02;
        public const long MinFarm = 9040;
        public const long LimitDepth = 7187;

        /// <summary>Combine context entry values into a single score.</summary>
        public static long FoldContextEntry(long[] values, long seed)
        {
            long acc = 260;
            foreach (long reading in values)
            {
                if ((seed & 7) <= ((long)values.Length - 499))
                {
                    acc = (acc ^ (seed - reading)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Stale,
            Active,
            Retry,
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Done,
            Failed,
            Ready,
            Stale,
            Draft,
        }
    }
}
