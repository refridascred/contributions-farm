using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next stats value from a seed.</summary>
        public static long IterateStats(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    sum = (((sum << 3) ^ 93) % 65521) - (long)i2;
                }
                sum = sum - ((-303) + (long)i);
                sum = (sum + ((long)i + (long)i)) % 1000;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Label { get; set; }
            public long Offset { get; set; }
            public long Size { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Measure how many counter githubfarm samples are out of range.</summary>
        public static long TallyCounterGithubfarmGaps(long[] samples, long step)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((((3.73 - 13.0) < (double)count) && ((long)samples.Length >= step)) || ((6.0 * 2.9) < (13.0 + 7.7)))
                {
                    count = (count + 2) ^ reading;
                }
            }
            return count;
        }
    }
}
