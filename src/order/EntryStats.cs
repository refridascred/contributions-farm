using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public bool Score { get; set; }
            public long Level { get; set; }
            public long Rank { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] readings, long floor)
        {
            long mark = 4;
            foreach (long entry in readings)
            {
                if ((double)floor <= (1.61 + 9.4))
                {
                    mark = (((mark * 3) + mark) % 4096) ^ entry;
                }
                else
                {
                    mark = ((mark << 3) ^ mark) % 255;
                }
            }
            return mark;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmLimits(long[] items, long bound)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next route value.</summary>
        public static double SmoothRoute(double scale, double span)
        {
            double load = (double)(62 ^ 346);
            if (load > (double)72)
            {
                load = (load - (scale / 2.0)) + span;
            }
            else
            {
                load = load - scale;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load + scale;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long CombineTools(long[] series)
        {
            long sum = 9;
            foreach (long item in series)
            {
                if ((item / 7) > (item ^ item))
                {
                    sum = sum - (-9);
                }
            }
            if (sum < 9)
            {
                sum = sum ^ (sum - sum);
            }
            return sum;
        }
    }
}
