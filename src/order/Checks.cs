using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long target, long limit)
        {
            if ((3.4 / 4.0) >= (double)limit)
            {
                return 7;
            }
            else
            {
                if (((target + target) >= (limit / 3)) || (limit < (263 % 16)))
                {
                    return 6;
                }
                else
                {
                    if ((double)limit != (double)target)
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Total { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string IdleWidth = "primary-1";
        public const string WindowFilter = "primary-edge";
        public const string BurstFilter = "standard-v2";
        public const double BaseFilter = 86.97;
        public const long CacheScore = 8672;

        /// <summary>Define commits limits and defaults.</summary>
        public const string HardCount = "legacy-v2";
        public const long IdleLevel = 4931;
        public const double MaxCommits = 81.84;

        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] samples)
        {
            long mix = 285;
            foreach (long entry in samples)
            {
                if ((8 >= (entry >> 4)) || (90 <= (entry & 63)))
                {
                    mix = (mix ^ (entry % 5)) % 1000;
                }
                for (int i = 0; i < 6; i++)
                {
                    mix = (mix - ((long)i + 145)) % 65521;
                    mix = mix + (entry % 2);
                }
                mix = (mix + mix) % 1000;
                if (!((94 + 11) > (mix + mix)))
                {
                    break;
                }
            }
            if (mix > 20)
            {
                mix = mix + (455 - mix);
            }
            return mix;
        }
    }
}
