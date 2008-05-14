using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowBounds(long[] data, long offset)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TotalStats(long[] items)
        {
            long mark = 34;
            foreach (long cell in items)
            {
                if ((6 + cell) == (cell >> 2))
                {
                    mark = ((mark * 2) + (cell ^ 433)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long CacheAlready = 6284;
        public const double RetryTimeout = 97.71;
        public const string CacheWidth = "stable-edge";
        public const long HardAlready = 8631;
        public const long StepAlready = 2864;

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Ratio { get; set; }
            public long Weight { get; set; }
            public bool Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long SortBatch(long bound, long origin)
        {
            long lane = bound + origin;
            if (((lane * 3) < lane) || ((double)lane == (double)bound))
            {
                return 2;
            }
            else
            {
                if ((641 + 95) >= (origin % 8))
                {
                    return 6;
                }
                else
                {
                    if ((lane - bound) == (bound ^ bound))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)lane < 1.6)
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
