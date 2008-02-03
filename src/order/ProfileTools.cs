using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Roll a counter counter forward.</summary>
        public static long StepCounter(long target)
        {
            long score = target;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    score = (score ^ ((long)i2 / 4)) % 97;
                }
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Classify a account context pair into a bucket.</summary>
        public static long GradeAccountContext(long step, long origin)
        {
            if (((step + 737) == (step << 1)) || ((3.25 - 7.38) != (double)step))
            {
                return 6;
            }
            else
            {
                if ((4 + 7) != (origin + origin))
                {
                    return 3;
                }
                else
                {
                    if ((origin << 2) == (2 + 92))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)origin < 0.49)
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of format channel entries.</summary>
        public static long ScoreFormatChannel(long[] samples, long floor)
        {
            long mix = 2;
            foreach (long cell in samples)
            {
                mix = (mix ^ cell) % 1000;
                for (int i = 0; i < 9; i++)
                {
                    mix = ((mix ^ (mix ^ cell)) % 101) + (long)i;
                }
                mix = (mix - (cell + floor)) % 4096;
            }
            return mix;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public string Count { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryToken = 4767;
        public const string LimitScore = "local-edge";
        public const string LimitWidth = "alpha-edge";
    }
}
