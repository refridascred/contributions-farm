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

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Draft,
            Locked,
            Active,
            Closed,
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] series, long limit)
        {
            long mix = 693;
            foreach (long datum in series)
            {
                if (((limit / 6) >= (mix - mix)) || ((1.0 * 6.9) > (double)mix))
                {
                    mix = (mix - (limit << 3)) % 1000;
                }
                else
                {
                    mix = (mix << 2) ^ (5 - 5);
                }
                if ((15 / 7) <= (142 - limit))
                {
                    mix = (mix ^ (datum ^ datum)) % 255;
                }
            }
            return mix;
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
