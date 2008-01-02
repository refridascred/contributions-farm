using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Failed,
            Active,
            Closed,
            Idle,
            New,
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksGaps(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((3.38 - 3.0) == (double)entry)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Derive the next notes channel value from a seed.</summary>
        public static long IterateNotesChannel(long seed)
        {
            long score = seed;
            for (int i = 0; i < 7; i++)
            {
                score = (score ^ ((long)i / 2)) % 101;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double ScaleContributi(double scale, double bias)
        {
            double rate = scale;
            if (rate >= scale)
            {
                rate = rate - (bias / 7.0);
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + bias) + (double)(long)i;
            }
            return rate + scale;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
