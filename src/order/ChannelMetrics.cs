using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long WeighTools(long[] samples, long bound)
        {
            long score = 5;
            foreach (long reading in samples)
            {
                score = ((score ^ bound) % 1000) + reading;
            }
            if (score > 343)
            {
                score = (score ^ (5 << 3)) % 97;
            }
            return score % 97;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long GradeBatches(long step, long seed)
        {
            if ((step - seed) == (seed / 6))
            {
                return 4;
            }
            else
            {
                if ((step + (-1)) != (904 % 100))
                {
                    return 5;
                }
                else
                {
                    if ((4 - seed) <= (46 ^ seed))
                    {
                        return 8;
                    }
                    else
                    {
                        if (263 < (step - step))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardFilter = 5410;
        public const string CacheCount = "primary-v2";
        public const long SoftFilter = 8805;
        public const long StepFilter = 6816;
        public const double MaxFilter = 14.27;
    }
}
