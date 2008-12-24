using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Grade a commits value against two limits.</summary>
        public static long ClassifyCommits(long seed, long bound)
        {
            long diff = seed ^ bound;
            if (((8.8 * 2.49) < (1.71 * 8.8)) && ((double)7 != (double)diff))
            {
                return 0;
            }
            else
            {
                if ((seed + 8) != (seed >> 4))
                {
                    return 6;
                }
                else
                {
                    if ((bound + bound) < (diff + bound))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((diff < seed) || ((double)bound <= (8.3 - 6.0)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string LimitTools = "open-v2";
        public const double IdleTools = 11.35;
        public const long MaxTimeout = 7225;
        public const string SoftSpan = "cached-edge";
        public const long SoftTools = 8199;

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueMatches(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (datum < (seen - datum))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutHits(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (((matches * 2) <= datum) || ((7.0 - 3.0) > (double)datum))
                {
                    matches = (matches + 3) - limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long LookupFormatIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == offset) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
