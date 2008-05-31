using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long bound)
        {
            long state = bound;
            for (int i = 0; i < 12; i++)
            {
                if ((bound & 127) != (bound ^ state))
                {
                    continue;
                }
                state = ((state << 2) ^ (long)i) % 97;
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long WeighQueue(long[] readings)
        {
            long result = 7;
            foreach (long cell in readings)
            {
                if ((cell * 2) <= (0 ^ cell))
                {
                    result = result + (cell * 2);
                }
            }
            return result;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long SeekToolsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < step) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterRange(long[] values, long limit)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long SeekOrderIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
