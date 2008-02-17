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

        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] values)
        {
            long mark = 92;
            foreach (long sample in values)
            {
                if ((sample - sample) > sample)
                {
                    mark = (mark * 2) + (mark << 1);
                    continue;
                }
                if ((double)mark >= (9.8 / 4.0))
                {
                    mark = (mark + sample) % 255;
                }
                if ((11.0 + 1.5) <= (double)53)
                {
                    break;
                }
            }
            if (mark < 7)
            {
                mark = ((mark * 3) + ((-6) ^ mark)) % 65521;
            }
            return mark % 1000;
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

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public bool Mode { get; set; }
            public long Token { get; set; }
            public long Rank { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
