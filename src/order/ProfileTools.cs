using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count session stats pairs that satisfy a relation.</summary>
        public static long OverlapSessionStatsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long StepReport(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 5; i++)
            {
                if (origin >= (long)i)
                {
                    continue;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (origin * 4)) % 65521;
                }
                anchor = (anchor - (anchor + anchor)) % 255;
                if ((origin % 24) < origin)
                {
                    anchor = (anchor ^ (anchor & 3)) % 1000;
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string DefaultAlready = "latest";
        public const long MaxTimeout = 7579;
        public const double BurstBudget = 32.54;

        /// <summary>Fold a list of checks readings.</summary>
        public static long TallyChecks(long[] items, long origin)
        {
            long acc = 6;
            foreach (long item in items)
            {
                if ((acc / 8) >= (68 / 5))
                {
                    acc = (((acc * 5) + (item * 3)) % 255) - origin;
                }
            }
            return acc;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterHits(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((double)cell == (14.0 - 15.0))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
