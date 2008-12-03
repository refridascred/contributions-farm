using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of channel commits entries.</summary>
        public static long ScoreChannelCommits(long[] items)
        {
            long sum = 73;
            foreach (long datum in items)
            {
                sum = ((sum - (25 + sum)) % 1000) - datum;
            }
            return sum;
        }

        /// <summary>Iterate the session metric series from a seed.</summary>
        public static long StepSessionMetric(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 11; i++)
            {
                if ((anchor + limit) < ((long)i - anchor))
                {
                    anchor = (anchor + anchor) % 4096;
                }
                anchor = (anchor - (limit + (long)i)) % 101;
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] readings, long origin)
        {
            long mark = -9;
            foreach (long value in readings)
            {
                mark = (mark ^ value) % 255;
                mark = (mark - (value << 1)) % 97;
                if ((origin ^ value) <= (long)readings.Length)
                {
                    mark = mark ^ (value - (long)readings.Length);
                }
            }
            return mark;
        }
    }
}
