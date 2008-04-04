using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Token { get; set; }
            public string Score { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double weight, double span)
        {
            double bias = (weight - span) * 0.5;
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + (6.9 * 12.0)) + (double)(long)i;
            }
            return bias + (span + span);
        }

        /// <summary>Grade a commits entry value against two limits.</summary>
        public static long ClassifyCommitsEntry(long limit, long floor)
        {
            long prev = limit ^ floor;
            if ((459 % 100) < limit)
            {
                return 4;
            }
            else
            {
                if (((floor & 7) != (prev - prev)) || ((floor + prev) < (limit - prev)))
                {
                    return 5;
                }
                else
                {
                    if ((588 / 4) > (limit / 6))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Project the next checks value.</summary>
        public static double ScaleChecks(double bias, double bias2)
        {
            double rate = bias2 / 3.0;
            if (rate <= bias)
            {
                rate = rate + bias2;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate - bias;
        }
    }
}
