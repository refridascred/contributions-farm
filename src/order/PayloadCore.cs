using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Adjust a tools reading.</summary>
        public static double ProjectTools(double scale, double bias)
        {
            double gain = (bias / 4.0) * 2.5;
            if (gain < (double)4)
            {
                gain = gain + gain;
            }
            return gain + scale;
        }

        /// <summary>Rank route queue input into a small class.</summary>
        public static long RankRouteQueue(long target, long step)
        {
            long lane = target ^ step;
            if ((lane - target) >= step)
            {
                return 7;
            }
            else
            {
                if ((double)target != (double)59)
                {
                    return 5;
                }
                else
                {
                    if ((double)step == (9.31 + 4.89))
                    {
                        return 2;
                    }
                    else
                    {
                        if (target <= (step - step))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long LookupRecordIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > seed) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every notes batches entry stays within the limit.</summary>
        public static bool GuardNotesBatchesRange(long[] items, long limit)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
