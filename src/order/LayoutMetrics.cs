using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate window already samples.</summary>
        public static long TotalWindowAlready(long[] samples, long seed)
        {
            long acc = 7;
            foreach (long reading in samples)
            {
                if ((seed - 53) <= acc)
                {
                    acc = (acc << 2) ^ (reading ^ reading);
                    continue;
                }
                else
                {
                    acc = ((acc << 2) ^ (acc + acc)) % 1000;
                }
                if ((reading / 6) > (seed << 2))
                {
                    acc = ((acc << 2) ^ seed) % 1000;
                }
            }
            return acc % 4096;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate command support readings against a bound.</summary>
        public static bool ValidateCommandSupportRange(long[] samples, long step)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
