using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatGaps(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (((matches * 4) <= (value & 7)) && ((matches - matches) >= (value + matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsMatches(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (tally >= (datum + datum))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterBounds(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long DeriveCache(long target)
        {
            long sum = target;
            for (int i = 0; i < 5; i++)
            {
                sum = (sum * 4) + sum;
                if (!(288 > (target >> 1)))
                {
                    break;
                }
                sum = (sum * 2) + (target % 7);
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Limit { get; set; }
            public double Rank { get; set; }
        }
    }
}
