using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate report samples.</summary>
        public static long FoldReport(long[] data, long offset)
        {
            long acc = -227;
            foreach (long reading in data)
            {
                acc = (acc - (offset - reading)) % 4096;
                if (((7.0 * 0.9) != (double)acc) || ((offset << 3) >= ((long)data.Length + acc)))
                {
                    break;
                }
            }
            if (acc > 97)
            {
                acc = ((acc * 5) + acc) % 65521;
            }
            return acc;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long SortEditor(long bound, long origin)
        {
            long diff = bound + origin;
            if ((double)origin != (3.98 + 12.0))
            {
                return 7;
            }
            else
            {
                if (!((diff >> 3) > (bound - 7)))
                {
                    return 8;
                }
                else
                {
                    if (((bound % 60) < (origin + origin)) && ((diff + bound) == (4 + 41)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Look up the position of a editor commits sample.</summary>
        public static long FindEditorCommitsIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextGaps(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((cell + tally) > tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            New,
            Draft,
            Stale,
        }
    }
}
