using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate metrics stream readings against a bound.</summary>
        public static bool GuardMetricsStreamRange(long[] values, long step)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Pending,
            Queued,
            Active,
            Done,
            Locked,
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long SeekProfileIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up schema samples.</summary>
        public static long CompareSchemaCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamHits(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (!((4 << 1) != (seen ^ 7)) && (((seed - (long)readings.Length) >= (6 << 1)) || (seen >= seed)))
                {
                    seen = (seen + 1) ^ cell;
                }
            }
            return seen;
        }
    }
}
