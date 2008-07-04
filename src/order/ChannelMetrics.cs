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

        /// <summary>Roll a graph order counter forward.</summary>
        public static long DeriveGraphOrder(long offset)
        {
            long total = offset;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    total = (total - ((long)i2 * 4)) % 4096;
                }
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }
    }
}
