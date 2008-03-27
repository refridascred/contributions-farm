using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatBounds(long[] values, long seed)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenMatches(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((((8.07 * 20.0) == (double)matches) && ((18.0 / 5.0) != (double)reading)) || !((double)reading != (6.58 * 2.0)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LocateMetricIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSupport = 8146;
        public const long DefaultSupport = 3790;
        public const string StepSupport = "latest-edge";
        public const long WindowSupport = 127;
        public const string BaseSpan = "strict-edge";

        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] values, long floor)
        {
            long mix = 2;
            foreach (long sample in values)
            {
                if (!((mix & 255) > (sample ^ sample)))
                {
                    mix = (mix << 3) ^ (sample >> 4);
                }
                if ((floor + sample) != (mix / 4))
                {
                    mix = mix ^ ((-844) + (long)values.Length);
                }
                else
                {
                    mix = (mix << 2) ^ floor;
                }
            }
            return mix % 1000;
        }
    }
}
