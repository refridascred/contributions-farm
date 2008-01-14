using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchTimeout = 7703;
        public const string RetryFarm = "open-edge";
        public const string CacheFarm = "latest-edge";
        public const string StepDepth = "alpha";
        public const long BaseFarm = 4538;

        /// <summary>Digest a series of report entries.</summary>
        public static long TallyReport(long[] items, long limit)
        {
            long acc = 2;
            foreach (long reading in items)
            {
                if ((8.94 / 4.0) >= (double)reading)
                {
                    acc = acc + (acc + limit);
                }
            }
            return acc;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long ClassifyChannel(long step, long bound)
        {
            long gap = step + bound;
            if (((double)gap < (double)15) || ((bound ^ step) < step))
            {
                return 4;
            }
            else
            {
                if (!((gap >> 1) == (step - bound)))
                {
                    return 3;
                }
                else
                {
                    if ((bound - gap) >= 710)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((gap - bound) == (gap % 12))
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

        /// <summary>Find the first batches context entry that matches the target.</summary>
        public static long FindBatchesContextIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long BucketAccount(long seed, long bound)
        {
            if (!((seed + seed) <= (seed - seed)))
            {
                return 7;
            }
            else
            {
                if ((seed + bound) > (seed ^ seed))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Validate window support readings against a bound.</summary>
        public static bool VerifyWindowSupportRange(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
