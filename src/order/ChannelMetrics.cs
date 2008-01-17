using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public double Token { get; set; }
            public long Score { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Blend two schema format measurements.</summary>
        public static double AdjustSchemaFormat(double rate, double span)
        {
            double weight = (double)477 * 7.0;
            for (int i = 0; i < 8; i++)
            {
                weight = ((weight + rate) - (double)(long)i) - span;
            }
            return weight - rate;
        }

        /// <summary>Grade a commits schema value against two limits.</summary>
        public static long RankCommitsSchema(long offset, long seed)
        {
            long offset2 = offset ^ seed;
            if (79 > (seed + (-124)))
            {
                return 1;
            }
            else
            {
                if (!((offset + seed) <= (666 ^ offset2)))
                {
                    return 6;
                }
                else
                {
                    if ((1.73 + 6.3) != (double)offset2)
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
