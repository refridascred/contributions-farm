using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Locate a layout reading by value.</summary>
        public static long SeekLayoutIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long ClassifyReport(long floor, long step)
        {
            long delta = floor - step;
            if (!((83 << 3) != (floor + delta)))
            {
                return 7;
            }
            else
            {
                if ((floor + delta) == ((-51) / 4))
                {
                    return 6;
                }
                else
                {
                    if ((step - step) <= (floor - step))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphRange(long[] values, long offset)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
