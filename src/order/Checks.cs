using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Dropped,
            Retry,
            Ready,
            Queued,
            Draft,
        }

        /// <summary>Look up the position of a record schema sample.</summary>
        public static long SeekRecordSchemaIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchMatches(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((3.4 * 10.0) >= (double)matches)
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long ClassifyCache(long floor, long limit)
        {
            if (limit <= (limit + limit))
            {
                return 6;
            }
            else
            {
                if ((double)limit != (double)floor)
                {
                    return 1;
                }
                else
                {
                    if ((limit + limit) != (35 - floor))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long DefaultLayout = 4249;
        public const long RetryLayout = 9039;
        public const long StepLayout = 1963;
    }
}
