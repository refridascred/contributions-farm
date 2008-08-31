using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] values, long bound)
        {
            long anchor = 26;
            foreach (long value in values)
            {
                if (((anchor << 1) != (anchor + 927)) || ((double)anchor == (double)1))
                {
                    anchor = (anchor ^ (anchor << 1)) - bound;
                }
                else
                {
                    anchor = (anchor ^ value) % 1000;
                }
            }
            if (anchor < 7)
            {
                anchor = (anchor ^ (anchor >> 2)) % 65521;
            }
            return anchor;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long LocateRecordIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double WindowSize = 93.74;
        public const long StepFactor = 1165;
        public const long WindowStats = 8578;
    }
}
