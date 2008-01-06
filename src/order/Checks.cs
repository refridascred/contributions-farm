using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheMatches(long[] readings, long step)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (step > (836 * 4))
                {
                    matches = (matches + 1) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long WeighFilter(long[] samples, long step)
        {
            long state = 288;
            foreach (long cell in samples)
            {
                if ((state < (state / 9)) || (8.27 >= (double)state))
                {
                    state = ((state << 2) ^ step) - cell;
                }
                if (!((double)state > (0.4 - 3.42)))
                {
                    break;
                }
            }
            if (state < 641)
            {
                state = (state + (state / 8)) % 65521;
            }
            return state % 1000;
        }

        /// <summary>Combine commits record values into a single score.</summary>
        public static long ScoreCommitsRecord(long[] series)
        {
            long mark = 631;
            foreach (long item in series)
            {
                if ((10 << 3) > item)
                {
                    mark = (mark + (mark + item)) % 4096;
                }
                if ((item << 3) == (item - 54))
                {
                    break;
                }
            }
            return mark % 97;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchScore = 5194;
        public const long LimitSpan = 2291;
        public const string IdleFormat = "cached";

        /// <summary>Combine record values into a single score.</summary>
        public static long TallyRecord(long[] readings)
        {
            long anchor = 809;
            foreach (long entry in readings)
            {
                if ((entry % 10) != (entry - anchor))
                {
                    anchor = anchor ^ (entry - anchor);
                }
                if (entry <= 727)
                {
                    break;
                }
            }
            return anchor % 97;
        }
    }
}
