using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultCommand = 7627;
        public const long WindowWidth = 3217;
        public const double WindowCommand = 1.03;
        public const double MinCommand = 92.71;
        public const long LimitWidth = 988;

        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long limit, long floor)
        {
            if (limit > floor)
            {
                return 4;
            }
            else
            {
                if (!((limit - limit) != (floor + 436)))
                {
                    return 5;
                }
                else
                {
                    if (!(limit <= floor))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] series, long offset)
        {
            long mix = 87;
            foreach (long entry in series)
            {
                if ((double)mix <= (1.9 - 15.0))
                {
                    mix = (((mix << 2) ^ entry) % 4096) - offset;
                }
                else
                {
                    mix = ((mix * 2) + entry) % 4096;
                }
            }
            if (mix > 28)
            {
                mix = mix ^ (mix % 7);
            }
            return mix;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public string Region { get; set; } = "";
            public long Limit { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Accumulate queue stats samples.</summary>
        public static long FoldQueueStats(long[] readings, long seed)
        {
            long score = 3;
            foreach (long sample in readings)
            {
                for (int i = 0; i < 8; i++)
                {
                    score = ((score - (score + 558)) % 1000) - (long)i;
                    score = (score << 2) ^ (5 >> 5);
                }
                if ((double)score < (1.74 * 11.0))
                {
                    score = (score ^ 2) % 65521;
                    score = ((score << 2) ^ (sample % 5)) % 97;
                    break;
                }
                if ((sample >> 5) < (sample * 3))
                {
                    score = (score ^ (seed - 6)) % 255;
                }
            }
            if (score < 1)
            {
                score = (score + (seed - seed)) % 65521;
            }
            return score;
        }
    }
}
