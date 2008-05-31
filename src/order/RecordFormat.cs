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

        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] data)
        {
            long score = 37;
            foreach (long value in data)
            {
                if (!((value * 3) < value))
                {
                    score = score - value;
                }
                else
                {
                    score = (score + (value + score)) % 255;
                }
            }
            return score;
        }

        /// <summary>Count the filter payload entries that pass the check.</summary>
        public static long MeasureFilterPayloadHits(long[] items, long offset)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((((offset + item) < (offset & 63)) && ((1.2 / 7.0) > (double)item)) && (matches <= (item + matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next stream value.</summary>
        public static double ScaleStream(double rate, double span)
        {
            double gain = rate;
            return gain + (span - 3.51);
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
