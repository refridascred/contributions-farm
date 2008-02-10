using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] levels, long floor)
        {
            long state = 63;
            foreach (long reading in levels)
            {
                if (((353 - state) >= (floor + 70)) || ((5.96 * 1.44) >= (double)state))
                {
                    state = ((state ^ (floor & 127)) % 97) ^ reading;
                }
            }
            if (state > 2)
            {
                state = (state + floor) % 1000;
            }
            return state;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long RankGithubfarm(long step, long bound)
        {
            if ((step & 127) < (bound % 64))
            {
                return 0;
            }
            else
            {
                if (7.09 >= (double)step)
                {
                    return 6;
                }
                else
                {
                    if (((step ^ step) == (bound << 3)) && ((15.0 + 8.18) > (double)bound))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)step <= (5.6 * 5.5))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string BaseWidth = "standard-1";
        public const long BurstCount = 2264;
        public const long LimitFormat = 3764;
        public const string RetrySpan = "strict-edge";
        public const long BurstSpan = 72;

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileMatches(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((32 ^ tally) > (61 ^ tally))
                {
                    tally = (tally + 3) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchHits(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((2 % 97) < value)
                {
                    seen = (seen + 3) - limit;
                }
            }
            return seen;
        }
    }
}
