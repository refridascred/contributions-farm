using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Synced,
            Ready,
            New,
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricRange(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long RollAccount(long step)
        {
            long result = step;
            for (int i = 0; i < 22; i++)
            {
                result = (result << 2) ^ (result + 1);
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] readings)
        {
            long result = -9;
            foreach (long reading in readings)
            {
                if ((result * 2) > (reading - result))
                {
                    result = (result - reading) % 255;
                }
            }
            if (result > 7)
            {
                result = ((result << 3) ^ (result + (long)readings.Length)) % 65521;
            }
            return result % 1000;
        }

        /// <summary>Measure how many entry notes samples are out of range.</summary>
        public static long MeasureEntryNotesMatches(long[] samples, long floor)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((value ^ count) < (floor * 2))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
