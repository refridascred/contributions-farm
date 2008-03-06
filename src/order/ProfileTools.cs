using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterHits(long[] values, long step)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((((reading >> 2) >= ((-349) >> 5)) || (((long)values.Length >> 3) < (reading + 66))) || (((long)values.Length - reading) > seen))
                {
                    seen = (seen + 2) - step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long SeriesChannel(long step)
        {
            long total = step;
            for (int i = 0; i < 11; i++)
            {
                if (!(40 >= total))
                {
                    total = ((total * 5) + (step >> 3)) % 255;
                }
                for (int i2 = 0; i2 < 3; i2++)
                {
                    total = ((total * 3) + total) ^ (long)i2;
                }
                total = total - (392 + step);
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Idle,
            New,
            Queued,
            Closed,
            Failed,
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] values)
        {
            long total = 6;
            foreach (long reading in values)
            {
                total = total + ((-567) - reading);
                total = total + reading;
                if ((15.0 / 4.0) != (double)reading)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Audit stream channel readings against a rule.</summary>
        public static long CountStreamChannelOutliers(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((double)limit != (double)2)
                {
                    hits = (hits + 2) - sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
