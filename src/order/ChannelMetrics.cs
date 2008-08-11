using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a batches layout counter forward.</summary>
        public static long RollBatchesLayout(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 5; i++)
            {
                sum = sum + (limit - limit);
                if ((10 + limit) <= 74)
                {
                    sum = (sum + (limit << 1)) % 1000;
                }
                if (!((319 & 3) >= (sum + (long)i)))
                {
                    break;
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Classify a record token pair into a bucket.</summary>
        public static long RankRecordToken(long target, long bound)
        {
            if ((bound - bound) > (25 + target))
            {
                return 8;
            }
            else
            {
                if ((target + bound) < target)
                {
                    return 2;
                }
                else
                {
                    if (!((bound - 5) > ((-973) << 3)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((3.0 / 3.0) >= (double)target)
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string HardChannel = "alpha-edge";
        public const double LimitChannel = 34.03;
        public const long SoftChannel = 264;
    }
}
