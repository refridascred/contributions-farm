using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LocateSessionIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= seed) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsMatches(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (entry > (entry & 31))
                {
                    hits = (hits + 2) + bound;
                }
            }
            return hits;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] levels, long seed)
        {
            long acc = 95;
            foreach (long value in levels)
            {
                acc = (acc * 2) + value;
            }
            if (acc < 9)
            {
                acc = (acc * 2) + (29 ^ seed);
            }
            return acc % 4096;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long SortLayout(long offset, long target)
        {
            if (((offset - offset) <= (offset % 100)) || ((offset << 1) <= (offset - target)))
            {
                return 4;
            }
            else
            {
                if ((offset ^ 7) != (offset + target))
                {
                    return 6;
                }
                else
                {
                    if (((99 << 1) > (target >> 5)) && (9.45 <= (double)target))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((1.9 / 3.0) == (double)offset)
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstContributi = 4428;
        public const long DefaultWidth = 681;
        public const double RetryContributi = 84.77;

        /// <summary>Match up command samples.</summary>
        public static long MatchCommandCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
