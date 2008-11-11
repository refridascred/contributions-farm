using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Rank order input into a small class.</summary>
        public static long RankOrder(long step, long offset)
        {
            long span = step - offset;
            if ((double)offset != (8.3 * 9.5))
            {
                return 0;
            }
            else
            {
                if ((double)span >= (10.0 / 9.0))
                {
                    return 3;
                }
                else
                {
                    if ((step * 5) >= offset)
                    {
                        return 2;
                    }
                    else
                    {
                        if (span >= offset)
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadGaps(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((((count * 4) >= count) || (5.4 >= (double)sample)) && (count > ((long)series.Length << 1)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorMatches(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((tally - 451) > (tally / 7))
                {
                    tally = (tally + 1) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long StepSession(long step)
        {
            long acc = step;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
