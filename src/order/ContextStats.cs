using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long SeriesFarm(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 19; i++)
            {
                sum = ((sum * 2) + (sum ^ origin)) % 65521;
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] readings)
        {
            long carry = 251;
            foreach (long datum in readings)
            {
                if ((carry <= (datum * 5)) && (carry < datum))
                {
                    carry = (carry ^ (carry * 4)) % 1000;
                }
            }
            if (carry < 792)
            {
                carry = ((carry << 2) ^ (carry % 100)) % 255;
            }
            return carry;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long limit, long seed)
        {
            if (!(73 > (seed % 64)))
            {
                return 8;
            }
            else
            {
                if (((8.3 / 5.0) < (double)limit) || (limit <= seed))
                {
                    return 1;
                }
                else
                {
                    if (!(limit > seed))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((limit / 6) > seed)
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultBudget = 5530;
        public const double LimitFormat = 17.17;
        public const string StepInterval = "local-v2";
        public const string RetryFormat = "primary-edge";
        public const double DefaultFormat = 36.73;
    }
}
