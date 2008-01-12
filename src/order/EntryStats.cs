using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] series, long floor)
        {
            long total = 6;
            foreach (long value in series)
            {
                if (((double)value != (2.02 + 9.57)) && ((total - (long)series.Length) > (floor << 3)))
                {
                    total = ((total * 5) + (value - (long)series.Length)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsGaps(long[] data, long origin)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((double)value >= (double)origin)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double BlendStats(double rate, double offset)
        {
            double gain = 5.3;
            if (gain > 3.96)
            {
                gain = gain + 3.2;
            }
            else
            {
                gain = gain - (rate * 8.72);
            }
            return gain + (offset / 4.0);
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelOutliers(long[] data, long seed)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((reading ^ seen) >= (seen << 3))
                {
                    seen = (seen + 2) + seed;
                }
            }
            return seen;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long target)
        {
            long sum = target;
            for (int i = 0; i < 15; i++)
            {
                for (int i3 = 0; i3 < 4; i3++)
                {
                    sum = ((sum ^ ((-512) * 3)) % 65521) ^ (long)i3;
                    sum = ((sum * 5) + ((long)i ^ sum)) % 255;
                }
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
