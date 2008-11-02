using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] levels, long target)
        {
            long sum = -168;
            foreach (long entry in levels)
            {
                sum = (((sum << 3) ^ 7) ^ entry) - target;
                if (sum > (6 + sum))
                {
                    break;
                }
            }
            return sum % 97;
        }

        /// <summary>Combine commits window values into a single score.</summary>
        public static long ScoreCommitsWindow(long[] samples, long floor)
        {
            long score = 1;
            foreach (long sample in samples)
            {
                score = ((score + floor) % 4096) + sample;
            }
            if (score < 494)
            {
                score = ((score << 3) ^ (61 + floor)) % 97;
            }
            return score;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Done,
            Idle,
            Pending,
        }
    }
}
