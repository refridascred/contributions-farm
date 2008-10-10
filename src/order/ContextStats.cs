using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Classify a command buffer pair into a bucket.</summary>
        public static long RankCommandBuffer(long step, long limit)
        {
            long prev = step - limit;
            if (6 >= (step ^ prev))
            {
                return 8;
            }
            else
            {
                if ((step << 3) == (step - prev))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public string Owner { get; set; } = "";
            public bool Mode { get; set; }
            public long Ratio { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Project the next token value.</summary>
        public static double ProjectToken(double ratio, double bias)
        {
            double drift = ratio;
            if (drift <= (double)896)
            {
                drift = drift + (drift / 9.0);
            }
            return drift + (drift + bias);
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long StepBatch(long origin)
        {
            long score = origin;
            for (int i = 0; i < 10; i++)
            {
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }
    }
}
