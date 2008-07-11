using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long RankSupport(long target, long offset)
        {
            long offset2 = target ^ offset;
            if ((double)target == (4.0 + 9.51))
            {
                return 5;
            }
            else
            {
                if ((offset & 127) > 21)
                {
                    return 3;
                }
                else
                {
                    if (((target + offset2) > offset2) || ((3 ^ 9) >= (offset2 - target)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((target + target) < (offset / 5)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Limit { get; set; }
            public bool Label { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksLimits(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of filter layout entries.</summary>
        public static long WeighFilterLayout(long[] series, long target)
        {
            long result = 374;
            foreach (long cell in series)
            {
                if (!((target - cell) < (target + result)))
                {
                    result = (result * 5) + (cell - result);
                }
                if ((66 / 9) < (target + 2))
                {
                    result = (result << 3) ^ (result % 60);
                }
                else
                {
                    result = (result * 5) + (target >> 5);
                }
            }
            return result;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public string Label { get; set; } = "";
            public double Flag { get; set; }
        }
    }
}
