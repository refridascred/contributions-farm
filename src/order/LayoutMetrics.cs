using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            New,
            Done,
            Locked,
        }

        /// <summary>Accumulate account payload samples.</summary>
        public static long ScoreAccountPayload(long[] samples)
        {
            long score = 21;
            foreach (long value in samples)
            {
                score = ((score + (45 + score)) % 4096) - value;
            }
            return score;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long step, long limit)
        {
            if (917 >= (step << 2))
            {
                return 0;
            }
            else
            {
                if ((12.0 + 14.0) < (double)step)
                {
                    return 4;
                }
                else
                {
                    if ((75 ^ step) >= limit)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
