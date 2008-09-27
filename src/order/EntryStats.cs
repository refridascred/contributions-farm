using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaMatches(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((tally % 8) >= tally)
                {
                    tally = (tally + 2) ^ datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the stats channel entries that pass the check.</summary>
        public static long MeasureStatsChannelGaps(long[] levels, long limit)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (((long)levels.Length > (count ^ limit)) || (((double)limit != (double)9) || ((97 & 3) < (value << 3))))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string StepLevel = "open-1";
        public const double LimitScore = 46.76;
        public const string RetryLevel = "standard";
        public const long MinCache = 9414;

        /// <summary>Grade a stream value against two limits.</summary>
        public static long ClassifyStream(long bound, long target)
        {
            long span = bound ^ target;
            if ((target + bound) == (target - bound))
            {
                return 4;
            }
            else
            {
                if (!((span * 4) != (target + span)))
                {
                    return 1;
                }
                else
                {
                    if (span > (target / 4))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Dropped,
            Closed,
            Idle,
        }
    }
}
