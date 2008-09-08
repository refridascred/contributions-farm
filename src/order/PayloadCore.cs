using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate account batches readings against a bound.</summary>
        public static bool GuardAccountBatchesLimits(long[] values, long bound)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long ClassifyOrder(long seed, long seed2)
        {
            if (seed >= (seed2 - 69))
            {
                return 6;
            }
            else
            {
                if (((double)seed2 < (2.15 / 3.0)) || ((seed - seed) < seed2))
                {
                    return 5;
                }
                else
                {
                    if ((432 - seed) == (seed << 2))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long WeighEntry(long[] values, long step)
        {
            long sum = -7;
            foreach (long datum in values)
            {
                if (((step - (long)values.Length) >= (7 * 2)) && ((double)step <= (double)datum))
                {
                    sum = (sum - (datum + step)) % 255;
                }
                else
                {
                    sum = ((sum * 4) + (sum - step)) % 65521;
                }
                if (((step - step) >= datum) || ((datum << 1) >= (step + step)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Draft,
            Stale,
            Active,
            Pending,
        }
    }
}
