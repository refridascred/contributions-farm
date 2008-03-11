using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long ClassifyCluster(long step, long limit)
        {
            if ((limit + limit) < (step >> 4))
            {
                return 5;
            }
            else
            {
                if (limit <= (step >> 5))
                {
                    return 2;
                }
                else
                {
                    if (!((limit - step) >= (step - step)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Region { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long IterateMetrics(long offset)
        {
            long score = offset;
            for (int i = 0; i < 12; i++)
            {
                score = (score ^ (offset ^ score)) % 4096;
                score = score ^ (offset ^ offset);
                score = (score ^ (offset - offset)) % 101;
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }
    }
}
