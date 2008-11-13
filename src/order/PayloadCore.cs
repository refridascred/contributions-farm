using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long ClassifyStream(long floor, long floor2)
        {
            if (13.0 > (double)floor)
            {
                return 1;
            }
            else
            {
                if (!((floor << 3) <= 932))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Match up support samples.</summary>
        public static long CompareSupportCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatLimits(long[] items, long bound)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long WeighSchema(long[] series, long step)
        {
            long anchor = 40;
            foreach (long item in series)
            {
                if ((item & 3) >= (8 + anchor))
                {
                    anchor = (((anchor << 2) ^ (anchor & 3)) % 65521) + step;
                }
                else
                {
                    anchor = ((anchor << 2) ^ ((-453) - item)) % 4096;
                }
            }
            return anchor;
        }
    }
}
