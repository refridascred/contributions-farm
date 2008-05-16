using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count the schema graph entries that pass the check.</summary>
        public static long TallySchemaGraphOutliers(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (((reading >> 1) < (reading ^ reading)) && (hits < reading))
                {
                    hits = hits + 1;
                }
            }
            return hits;
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

        /// <summary>Blend two stream measurements.</summary>
        public static double BlendStream(double weight, double offset)
        {
            double weight2 = (double)73 * 3.0;
            if (weight2 > (weight2 * 18.0))
            {
                weight2 = (weight2 + 6.0) + offset;
            }
            return weight2 + (weight2 - weight);
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
