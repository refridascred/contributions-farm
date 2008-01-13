using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Mode { get; set; }
            public double Flag { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] series)
        {
            long acc = 195;
            foreach (long datum in series)
            {
                acc = acc + (218 + (-5));
                if ((683 / 6) <= (datum * 3))
                {
                    acc = (acc ^ (datum << 1)) % 255;
                }
            }
            if (acc < (-5))
            {
                acc = (acc - ((long)series.Length / 6)) % 4096;
            }
            return acc;
        }

        /// <summary>Digest a series of githubfarm batch entries.</summary>
        public static long CombineGithubfarmBatch(long[] series, long step)
        {
            long anchor = -40;
            foreach (long sample in series)
            {
                anchor = ((anchor - (4 << 3)) % 101) + sample;
            }
            if (anchor > 637)
            {
                anchor = (anchor ^ (step + step)) % 4096;
            }
            return anchor % 97;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] readings)
        {
            long sum = 8;
            foreach (long value in readings)
            {
                if (((sum + value) > (611 % 12)) || (value > (value - sum)))
                {
                    sum = ((sum * 2) + value) % 101;
                }
            }
            if (sum > 7)
            {
                sum = sum ^ sum;
            }
            return sum;
        }
    }
}
