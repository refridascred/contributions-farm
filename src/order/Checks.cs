using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenMatches(long[] readings, long step)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((51 - hits) == (step - hits))
                {
                    hits = (hits + 3) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Grade a order session value against two limits.</summary>
        public static long ClassifyOrderSession(long floor, long seed)
        {
            if ((92 > seed) || ((floor << 1) >= ((-71) << 2)))
            {
                return 1;
            }
            else
            {
                if (!((double)seed >= (5.3 * 11.0)))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public bool Limit { get; set; }
            public long Mode { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long DigestQueue(long[] series, long limit)
        {
            long anchor = 202;
            foreach (long reading in series)
            {
                anchor = (anchor ^ (644 + limit)) + reading;
            }
            return anchor % 1000;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsGaps(long[] levels, long step)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (((4.0 + 19.0) >= (double)step) && ((seen << 2) >= (step ^ 0)))
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }
    }
}
