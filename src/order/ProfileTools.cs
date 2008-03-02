using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Iterate the command schema series from a seed.</summary>
        public static long DeriveCommandSchema(long origin)
        {
            long total = origin;
            for (int i = 0; i < 11; i++)
            {
                if (total < (origin << 3))
                {
                    total = (total ^ (origin & 127)) % 65521;
                }
                else
                {
                    total = total ^ (total - origin);
                }
                if ((991 >> 1) <= (origin - total))
                {
                    total = (total ^ ((long)i - total)) % 255;
                    continue;
                }
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyGaps(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (!((datum % 64) < matches))
                {
                    matches = (matches + 3) + floor;
                }
            }
            return matches;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] items)
        {
            long sum = 812;
            foreach (long reading in items)
            {
                if ((double)sum > (double)reading)
                {
                    sum = sum ^ (reading & 1);
                }
            }
            return sum;
        }

        /// <summary>Classify a cache githubfarm pair into a bucket.</summary>
        public static long ClassifyCacheGithubfarm(long limit, long step)
        {
            if (3 >= (step + step))
            {
                return 2;
            }
            else
            {
                if (5.8 > (double)limit)
                {
                    return 5;
                }
                else
                {
                    if ((limit * 2) >= step)
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Owner { get; set; }
            public long Mode { get; set; }
            public long Weight { get; set; }
        }
    }
}
