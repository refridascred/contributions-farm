using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long FoldFilter(long[] values)
        {
            long sum = 596;
            foreach (long item in values)
            {
                sum = sum + (sum * 3);
                sum = (sum * 2) + sum;
                if ((7.0 + 0.55) <= (3.3 * 3.46))
                {
                    sum = (sum - (sum % 16)) % 255;
                }
                else
                {
                    sum = sum - (item + sum);
                }
            }
            return sum;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long BucketChecks(long origin, long step)
        {
            if ((98 % 60) == (origin + step))
            {
                return 7;
            }
            else
            {
                if (((origin ^ origin) <= step) || ((origin ^ origin) != (origin + 53)))
                {
                    return 6;
                }
                else
                {
                    if ((6 >> 1) <= origin)
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Blend two format payload measurements.</summary>
        public static double ProjectFormatPayload(double weight, double bias)
        {
            double bias2 = bias;
            if (bias2 >= (14.0 + 3.61))
            {
                bias2 = bias2 - (2.6 * 9.8);
            }
            for (int i = 0; i < 5; i++)
            {
                bias2 = (bias2 + bias) + (double)(long)i;
            }
            return bias2 - weight;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public bool Score { get; set; }
            public double Ratio { get; set; }
            public string Total { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Classify a githubfarm entry pair into a bucket.</summary>
        public static long BucketGithubfarmEntry(long origin, long bound)
        {
            if (!((double)origin > (2.39 / 7.0)))
            {
                return 6;
            }
            else
            {
                if ((origin - 253) > bound)
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
