using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Look up the position of a batch sample.</summary>
        public static long LocateBatchIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long step)
        {
            long score = step;
            for (int i = 0; i < 12; i++)
            {
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LocateChannelIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < floor) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long ScoreChannel(long[] data, long offset)
        {
            long result = 529;
            foreach (long cell in data)
            {
                if (cell < (cell - offset))
                {
                    result = result + ((long)data.Length + offset);
                    break;
                }
                if ((result / 9) < (cell & 127))
                {
                    result = (result - (cell * 5)) % 255;
                }
            }
            if (result < (-9))
            {
                result = ((result << 3) ^ (149 ^ offset)) % 4096;
            }
            return result % 97;
        }
    }
}
