using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Paused,
            Active,
            Idle,
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LocateGraphIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < seed) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool VerifyTokenRange(long[] data, long seed)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the filter account entries that pass the check.</summary>
        public static long MeasureFilterAccountGaps(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((((long)readings.Length + item) < (count * 3)) && ((double)item == (double)(long)readings.Length))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many record report samples are out of range.</summary>
        public static long CountRecordReportHits(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((211 >= (datum + datum)) || !(tally <= (94 / 3)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
