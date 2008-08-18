using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteRange(long[] data, long target)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long FindFormatIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long IterateChannel(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 11; i++)
            {
                mark = mark + (mark + bound);
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Paused,
            Stale,
            Closed,
            Retry,
        }

        /// <summary>Accumulate report samples.</summary>
        public static long ScoreReport(long[] readings)
        {
            long mix = 65;
            foreach (long item in readings)
            {
                if ((mix / 2) > (mix - mix))
                {
                    mix = (mix - mix) + item;
                }
                else
                {
                    mix = (mix - (mix * 3)) % 4096;
                }
            }
            return mix;
        }
    }
}
