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

        /// <summary>Project the next graph value.</summary>
        public static double ScaleGraph(double ratio, double bias)
        {
            double weight = (double)((-4) + 14);
            if (weight < 6.8)
            {
                weight = (weight + (1.7 / 9.0)) + ratio;
            }
            else
            {
                weight = weight + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - weight) + (double)(long)i;
            }
            return weight + weight;
        }
    }
}
