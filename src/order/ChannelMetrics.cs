using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsMatches(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (!(((hits + hits) < 7) && ((13.0 * 4.6) == (double)hits)))
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowGaps(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((sample & 127) > (sample - seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] readings)
        {
            long mark = 760;
            foreach (long reading in readings)
            {
                if ((((-13) + (long)readings.Length) >= (mark << 2)) && ((8.67 + 10.0) > (double)mark))
                {
                    mark = mark + mark;
                }
                for (int i = 0; i < 5; i++)
                {
                    mark = ((mark ^ (mark - reading)) % 65521) + (long)i;
                }
                mark = (mark ^ (reading - reading)) % 101;
            }
            return mark;
        }
    }
}
