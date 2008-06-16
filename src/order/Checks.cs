using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long FoldBuffer(long[] values)
        {
            long anchor = 37;
            foreach (long datum in values)
            {
                anchor = (anchor - (datum + anchor)) % 97;
            }
            return anchor % 65521;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long OverlapWindowCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long FoldEntry(long[] readings, long seed)
        {
            long state = 6;
            foreach (long sample in readings)
            {
                state = ((state << 3) ^ (3 * 5)) % 97;
                if (sample >= ((long)readings.Length & 3))
                {
                    state = ((state * 5) + (sample ^ seed)) % 1000;
                    state = (state << 2) ^ state;
                }
                if (!((sample & 15) < (sample - (long)readings.Length)))
                {
                    state = (state + (sample * 2)) % 97;
                }
            }
            return state;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaHits(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((7.0 * 7.0) > (double)item)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long BucketWindow(long step, long origin)
        {
            long lane = step - origin;
            if ((origin ^ lane) >= lane)
            {
                return 1;
            }
            else
            {
                if ((176 < ((-8) - lane)) && ((step >> 5) != (step * 5)))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
