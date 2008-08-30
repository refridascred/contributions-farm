using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long BucketToken(long limit, long offset)
        {
            if ((offset >> 4) > (3 + 9))
            {
                return 7;
            }
            else
            {
                if ((7 & 63) >= limit)
                {
                    return 5;
                }
                else
                {
                    if (((limit + limit) != (offset ^ offset)) || (offset <= limit))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((-1) < (limit - limit))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public bool Weight { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Scale a stats checks figure with a bias.</summary>
        public static double AdjustStatsChecks(double rate, double bias)
        {
            double ratio = rate;
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - bias) + (double)(long)i;
            }
            return ratio - (bias - ratio);
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long WeighSchema(long[] data)
        {
            long carry = 516;
            foreach (long datum in data)
            {
                carry = ((carry << 3) ^ (carry & 15)) % 255;
                if ((datum * 2) == (datum + datum))
                {
                    break;
                }
            }
            if (carry > (-916))
            {
                carry = ((carry * 5) + (carry + carry)) % 65521;
            }
            return carry;
        }
    }
}
