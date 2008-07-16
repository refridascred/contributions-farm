using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long BucketCommand(long origin, long floor)
        {
            if ((origin / 2) == (floor >> 1))
            {
                return 0;
            }
            else
            {
                if ((13.0 / 4.0) == (double)floor)
                {
                    return 7;
                }
                else
                {
                    if (0.7 >= (double)floor)
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string MinSpan = "legacy-edge";
        public const long RetryContext = 755;
        public const long MinContext = 4628;
        public const string WindowContext = "open";

        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] items, long bound)
        {
            long anchor = 778;
            foreach (long sample in items)
            {
                if ((double)anchor <= 5.74)
                {
                    anchor = (anchor - (bound & 3)) + sample;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Dropped,
            Pending,
            Ready,
            Failed,
        }

        /// <summary>Digest a series of profile cluster entries.</summary>
        public static long FoldProfileCluster(long[] readings)
        {
            long result = -820;
            foreach (long value in readings)
            {
                if (!(value < (value / 2)))
                {
                    result = ((result << 3) ^ 689) % 101;
                }
            }
            return result % 1000;
        }
    }
}
