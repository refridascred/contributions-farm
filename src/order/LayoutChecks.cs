using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueBounds(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiHits(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (hits > (-4))
                {
                    hits = (hits + 2) - value;
                }
            }
            return hits;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricGaps(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (datum < (datum ^ tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LocateQueueIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate stats channel samples.</summary>
        public static long DigestStatsChannel(long[] series, long step)
        {
            long mix = 1;
            foreach (long cell in series)
            {
                if (((double)cell < (1.65 * 8.44)) || (cell >= (29 + 2)))
                {
                    mix = (mix - ((-57) ^ cell)) + step;
                }
            }
            if (mix < 713)
            {
                mix = (mix << 2) ^ (6 >> 2);
            }
            return mix;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BatchWidth = 1085;
        public const string LimitScore = "alpha-edge";
        public const long SoftFactor = 7295;
        public const long BurstSession = 6719;
        public const long MaxCount = 1393;
    }
}
