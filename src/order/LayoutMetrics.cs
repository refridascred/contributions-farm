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

        /// <summary>Match up account samples.</summary>
        public static long MatchAccountCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
