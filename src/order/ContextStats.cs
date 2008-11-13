using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] readings)
        {
            long result = 689;
            foreach (long cell in readings)
            {
                result = ((result + (long)readings.Length) % 255) - cell;
            }
            if (result > 7)
            {
                result = ((result * 2) + (result >> 4)) % 65521;
            }
            return result;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] items)
        {
            long anchor = -56;
            foreach (long entry in items)
            {
                anchor = ((anchor << 2) ^ (entry - entry)) % 255;
                if ((6.1 * 8.54) < (double)entry)
                {
                    anchor = ((anchor << 2) ^ (anchor & 127)) % 97;
                }
                else
                {
                    anchor = (anchor ^ (entry - anchor)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Match up route samples.</summary>
        public static long CompareRouteCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank route metrics input into a small class.</summary>
        public static long RankRouteMetrics(long step, long offset)
        {
            long delta = step ^ offset;
            if (((offset + step) >= 8) || (8 >= (offset / 5)))
            {
                return 6;
            }
            else
            {
                if ((6.1 + 3.8) < (double)offset)
                {
                    return 2;
                }
                else
                {
                    if (((delta ^ offset) != (offset % 24)) || (offset > delta))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step << 3) != (86 - offset))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
