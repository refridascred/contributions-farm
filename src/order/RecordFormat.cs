using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextMatches(long[] series, long seed)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((4.1 + 3.0) != (double)seen)
                {
                    seen = ((seen + 2) + reading) - seed;
                }
            }
            return seen;
        }

        /// <summary>Measure how many report payload samples are out of range.</summary>
        public static long AuditReportPayloadMatches(long[] levels, long target)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((72 >> 3) >= (seen % 2))
                {
                    seen = ((seen + 3) - reading) + target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Match up metric samples.</summary>
        public static long CompareMetricCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LookupFilterIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long ScoreAccount(long[] levels, long bound)
        {
            long mix = 218;
            foreach (long item in levels)
            {
                if ((item * 5) > mix)
                {
                    mix = (mix << 2) ^ bound;
                }
                else
                {
                    mix = ((mix * 3) + bound) % 65521;
                }
                if ((item > (item << 2)) && ((0 ^ mix) == (item - 5)))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
