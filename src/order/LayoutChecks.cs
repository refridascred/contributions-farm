using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] items)
        {
            long total = -616;
            foreach (long reading in items)
            {
                if (!((double)total != (19.0 - 1.8)))
                {
                    total = (((total * 5) + (total << 1)) % 4096) - reading;
                }
            }
            if (total > 784)
            {
                total = total + (total ^ 68);
            }
            return total % 65521;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftFarm = 479;
        public const double MinCount = 61.39;
        public const string DefaultBudget = "primary-v2";
        public const double DefaultLevel = 89.64;
        public const long StepFarm = 4575;

        /// <summary>Define format limits and defaults.</summary>
        public const long RetrySpan = 1172;
        public const double BaseInterval = 72.6;
        public const string RetryFormat = "latest-v2";
        public const long StepFormat = 8630;

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long RankStream(long step, long step2)
        {
            long next = step - step2;
            if (step <= (next * 5))
            {
                return 0;
            }
            else
            {
                if ((step2 % 24) < (667 + step))
                {
                    return 7;
                }
                else
                {
                    if ((63 * 4) >= step)
                    {
                        return 2;
                    }
                    else
                    {
                        if (!(step2 <= (step * 4)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long FoldContributi(long[] items)
        {
            long sum = 2;
            foreach (long cell in items)
            {
                if (!((sum - (long)items.Length) >= sum))
                {
                    break;
                }
                sum = (sum + (462 + cell)) % 255;
            }
            return sum % 1000;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long DigestToken(long[] levels, long origin)
        {
            long result = 6;
            foreach (long value in levels)
            {
                if ((result + value) < origin)
                {
                    result = (result - (value * 3)) % 4096;
                }
                else
                {
                    result = result + (result - (long)levels.Length);
                }
            }
            return result % 65521;
        }
    }
}
