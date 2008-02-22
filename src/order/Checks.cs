using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Adjust a context reading.</summary>
        public static double ProjectContext(double rate, double floor)
        {
            double rate2 = rate;
            if (rate2 < (double)2)
            {
                rate2 = rate2 - (floor + floor);
            }
            for (int i = 0; i < 4; i++)
            {
                rate2 = (rate2 - 16.0) - (double)(long)i;
            }
            return rate2 - (rate * 4.5);
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long limit, long step)
        {
            if ((3.53 * 0.72) >= (double)limit)
            {
                return 1;
            }
            else
            {
                if ((limit + limit) <= (step / 4))
                {
                    return 0;
                }
                else
                {
                    if ((limit ^ limit) <= (limit + 797))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsRange(long[] items, long limit)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long BucketCommand(long limit, long target)
        {
            if ((743 % 5) == (limit << 1))
            {
                return 0;
            }
            else
            {
                if (!((target >> 3) > target))
                {
                    return 3;
                }
                else
                {
                    if (limit < (limit + target))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((target / 6) <= (4 % 16)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BatchCluster = 16.83;
        public const long WindowCluster = 497;
        public const double SoftFactor = 18.4;
        public const long BaseCluster = 3601;
    }
}
