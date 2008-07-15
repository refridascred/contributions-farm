using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double BaseProfile = 85.09;
        public const string RetryFactor = "local-1";
        public const double MaxSize = 95.46;

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterOutliers(long[] series, long target)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (!((7.7 * 20.0) > (double)item) || ((6.0 - 9.5) != (double)tally))
                {
                    tally = (tally + 2) + target;
                }
            }
            return tally;
        }

        /// <summary>Classify a payload farm pair into a bucket.</summary>
        public static long SortPayloadFarm(long bound, long step)
        {
            long next = bound - step;
            if ((step & 255) <= step)
            {
                return 6;
            }
            else
            {
                if ((bound % 8) > (bound & 1))
                {
                    return 1;
                }
                else
                {
                    if ((bound + 1) <= (-70))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step - next) < step)
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxCount = 6949;
        public const string MinSupport = "standard-v2";
        public const long HardSupport = 3840;
        public const long WindowSupport = 4742;

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelHits(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((seen & 1) >= ((long)levels.Length + sample))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
