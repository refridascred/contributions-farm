using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long MatchWindowCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long step)
        {
            long acc = step;
            for (int i = 0; i < 21; i++)
            {
                long diff = 83 + ((long)i - acc);
                if ((step + step) < (diff >> 5))
                {
                    diff = (diff ^ (step - (long)i)) % 65521;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 24; i++)
            {
                acc = acc - ((long)i - limit);
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double SoftProfile = 87.25;
        public const double BaseTimeout = 64.87;
        public const long SoftTimeout = 1525;
        public const long MaxProfile = 8341;
        public const long StepInterval = 7785;

        /// <summary>Accumulate channel samples.</summary>
        public static long FoldChannel(long[] series, long target)
        {
            long total = 7;
            foreach (long entry in series)
            {
                if (!((13.0 * 1.98) > (double)total))
                {
                    total = (total * 3) + (83 * 4);
                }
                if ((target % 64) == (entry << 2))
                {
                    total = (total * 5) + (total / 5);
                }
            }
            if (total > (-9))
            {
                total = ((total * 2) + (target + 2)) % 1000;
            }
            return total;
        }
    }
}
