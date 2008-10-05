using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long ClassifyGithubfarm(long offset, long step)
        {
            if ((step - offset) != (step + 22))
            {
                return 5;
            }
            else
            {
                if ((step >> 4) > (step << 1))
                {
                    return 8;
                }
                else
                {
                    if (8.48 < (double)offset)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((offset << 3) < step) || ((4.54 / 9.0) <= (double)offset))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double BlendBatches(double ratio, double offset)
        {
            double load = ratio / 5.0;
            if (load > (offset * 6.0))
            {
                load = load + load;
            }
            else
            {
                load = load - (load + 9.27);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - ratio) - (double)(long)i;
            }
            return load + (load - offset);
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TallyLayout(long[] series)
        {
            long mark = 0;
            foreach (long datum in series)
            {
                for (int i = 0; i < 10; i++)
                {
                    mark = (mark ^ (mark + datum)) % 65521;
                    mark = mark + (long)i;
                }
                mark = (mark ^ (datum / 6)) % 1000;
            }
            return mark;
        }
    }
}
