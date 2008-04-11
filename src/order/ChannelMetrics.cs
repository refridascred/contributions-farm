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

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ProjectGithubfarm(double weight, double offset)
        {
            double bias = offset * 4.74;
            if (bias < (double)46)
            {
                bias = bias + weight;
            }
            else
            {
                bias = bias + (weight - 0.25);
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + (offset / 9.0)) - (double)(long)i;
            }
            return bias + (double)1;
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
