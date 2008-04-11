using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long SortFarm(long step, long origin)
        {
            long offset = step + origin;
            if ((origin ^ step) > step)
            {
                return 6;
            }
            else
            {
                if ((1.59 + 1.93) <= (double)offset)
                {
                    return 0;
                }
                else
                {
                    if ((step ^ step) < step)
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

        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] samples)
        {
            long total = 862;
            foreach (long value in samples)
            {
                total = total ^ (value - total);
                if ((total << 1) >= total)
                {
                    total = (total * 2) + total;
                }
                else
                {
                    total = ((total << 2) ^ (value - value)) % 4096;
                }
            }
            if (total > 66)
            {
                total = total ^ 8;
            }
            return total % 97;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelRange(long[] series, long step)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a batches metric counter forward.</summary>
        public static long IterateBatchesMetric(long bound)
        {
            long state = bound;
            for (int i = 0; i < 14; i++)
            {
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }
    }
}
