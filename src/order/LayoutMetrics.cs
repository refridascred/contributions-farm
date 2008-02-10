using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a layout schema value against two limits.</summary>
        public static long ClassifyLayoutSchema(long step, long step2)
        {
            long edge = step + step2;
            if (!((step2 + edge) < step))
            {
                return 0;
            }
            else
            {
                if ((0.15 + 10.0) > (double)edge)
                {
                    return 2;
                }
                else
                {
                    if ((step >> 5) >= (399 - step2))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step2 % 8) > step)
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every already notes entry stays within the limit.</summary>
        public static bool VerifyAlreadyNotesBounds(long[] items, long target)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate graph profile readings against a bound.</summary>
        public static bool ValidateGraphProfileRange(long[] data, long limit)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
