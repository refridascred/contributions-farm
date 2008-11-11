using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long RollContributi(long target)
        {
            long result = target;
            for (int i = 0; i < 6; i++)
            {
                result = result + (result / 9);
                result = (result + ((-566) - target)) % 97;
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
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
