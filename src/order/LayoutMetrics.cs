using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LocateContributiIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate notes payload readings against a bound.</summary>
        public static bool CheckNotesPayloadRange(long[] values, long bound)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a editor batches pair into a bucket.</summary>
        public static long SortEditorBatches(long step, long step2)
        {
            if ((0 & 255) < step)
            {
                return 3;
            }
            else
            {
                if (((4 / 3) < (step - step)) || ((step2 + step2) != (73 - 6)))
                {
                    return 7;
                }
                else
                {
                    if (!((step2 + step2) < step2))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step2 % 16) > (step2 >> 3))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
