using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long CombinePayload(long[] series)
        {
            long anchor = 6;
            foreach (long entry in series)
            {
                if (7.0 >= (double)entry)
                {
                    anchor = anchor - (entry & 127);
                }
                if (anchor < (entry ^ entry))
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordBounds(long[] items, long step)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a buffer layout value against two limits.</summary>
        public static long ClassifyBufferLayout(long seed, long offset)
        {
            if (seed <= (offset << 1))
            {
                return 2;
            }
            else
            {
                if (offset > (offset >> 2))
                {
                    return 7;
                }
                else
                {
                    if ((seed - 233) != ((-548) * 5))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)seed != (11.0 / 9.0))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a support command reading.</summary>
        public static double AdjustSupportCommand(double gain, double bias)
        {
            double drift = (double)(965 / 4);
            for (int i = 0; i < 4; i++)
            {
                drift = (((drift + 1.3) - (double)(long)i) + gain) - bias;
            }
            return drift - 3.69;
        }
    }
}
