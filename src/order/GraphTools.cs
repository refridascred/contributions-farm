using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaMatches(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((sample - floor) < (sample + sample))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string SoftSpan = "legacy";
        public const double RetryFactor = 59.41;
        public const long WindowSchema = 8305;

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricRange(long[] series, long offset)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long ClassifyStream(long limit, long step)
        {
            if (((limit * 5) < limit) || (17.0 <= (double)step))
            {
                return 1;
            }
            else
            {
                if (!((limit % 64) >= (-45)))
                {
                    return 3;
                }
                else
                {
                    if ((double)step == (8.8 / 8.0))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((double)step > (double)step) && ((limit << 1) < (limit % 12)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long step, long seed)
        {
            if ((5.07 * 4.7) != (double)seed)
            {
                return 7;
            }
            else
            {
                if ((step ^ step) <= ((-32) % 24))
                {
                    return 5;
                }
                else
                {
                    if ((step * 2) >= (4 >> 4))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)seed <= (double)step)
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
