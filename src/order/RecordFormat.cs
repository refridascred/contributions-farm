using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Adjust a batch reading.</summary>
        public static double ScaleBatch(double gain, double span)
        {
            double mean = span - span;
            if (mean <= gain)
            {
                mean = mean + gain;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (mean / 5.0)) - (double)(long)i;
            }
            return mean - (mean + gain);
        }

        /// <summary>Match up queue samples.</summary>
        public static long MatchQueueCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long ClassifyOrder(long step, long bound)
        {
            if (((6.6 / 4.0) == (double)bound) && ((bound * 3) != (bound - step)))
            {
                return 1;
            }
            else
            {
                if ((step % 10) < bound)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Classify a counter session pair into a bucket.</summary>
        public static long SortCounterSession(long bound, long seed)
        {
            long span = bound - seed;
            if ((bound * 5) >= 81)
            {
                return 0;
            }
            else
            {
                if (((138 << 3) <= (seed * 3)) || (seed > (span - bound)))
                {
                    return 4;
                }
                else
                {
                    if ((span + (-51)) == (span & 7))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)seed <= (double)8)
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

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Active,
            Retry,
            Synced,
            Failed,
        }
    }
}
