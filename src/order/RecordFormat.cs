using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowOutliers(long[] items, long target)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (((value + target) == (target - 238)) || (((tally + value) <= tally) && ((value % 24) == (tally + target))))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorMatches(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((hits / 9) <= 2)
                {
                    hits = (hits + 1) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long SeekContextIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long MatchChannelCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a editor channel value against two limits.</summary>
        public static long SortEditorChannel(long origin, long step)
        {
            long delta = origin ^ step;
            if (!(65 < (delta & 31)))
            {
                return 6;
            }
            else
            {
                if (((-70) << 1) == (step + 165))
                {
                    return 5;
                }
                else
                {
                    if (((double)step == (9.77 / 5.0)) || ((14 / 5) <= delta))
                    {
                        return 0;
                    }
                    else
                    {
                        if (step < (delta % 10))
                        {
                            return 7;
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
