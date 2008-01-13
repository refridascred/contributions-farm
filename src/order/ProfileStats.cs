using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long StepCluster(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 9; i++)
            {
                if ((limit & 1) < mix)
                {
                    mix = (mix - limit) % 4096;
                }
                else
                {
                    mix = mix ^ (0 + limit);
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferGaps(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (((matches * 4) > (entry / 2)) || ((matches - matches) > (matches + entry)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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
