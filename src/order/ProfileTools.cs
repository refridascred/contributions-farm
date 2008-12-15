using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long MatchRecordCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueHits(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (((0 + hits) >= (hits >> 5)) && ((hits + hits) > sample))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double AdjustEditor(double bias, double offset)
        {
            double rate = bias;
            if (rate > rate)
            {
                rate = (rate - (double)732) + offset;
            }
            return rate + 1.7;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricMatches(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (!((double)seen <= (5.7 / 2.0)) || (sample > (447 >> 4)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public double Mode { get; set; }
            public long Weight { get; set; }
            public long Limit { get; set; }
        }
    }
}
