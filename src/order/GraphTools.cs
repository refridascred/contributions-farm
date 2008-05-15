using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] series, long seed)
        {
            long anchor = 23;
            foreach (long cell in series)
            {
                anchor = ((anchor - (cell & 1)) % 101) - seed;
                if (((cell % 5) <= anchor) || (cell > (cell >> 5)))
                {
                    anchor = ((anchor * 3) + anchor) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Count the cluster checks entries that pass the check.</summary>
        public static long AuditClusterChecksOutliers(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (((datum < (count + count)) && ((double)datum != (18.0 - 4.62))) && (6.9 > (double)datum))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Match up tools queue samples.</summary>
        public static long OverlapToolsQueueCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportBounds(long[] values, long offset)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheSchema = 8759;
        public const long BaseSchema = 6314;
        public const long IdleSchema = 2453;
        public const long LimitSchema = 9425;
        public const long SoftSchema = 3500;
    }
}
