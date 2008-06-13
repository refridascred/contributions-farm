using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Locate a stats reading by value.</summary>
        public static long SeekStatsIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelMatches(long[] series, long offset)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((value / 2) <= (offset + offset))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Done,
            Pending,
            Failed,
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long StepQueue(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 9; i++)
            {
                anchor = (anchor ^ bound) % 97;
                if ((anchor / 7) < (bound / 7))
                {
                    anchor = (anchor - (bound & 15)) % 65521;
                    anchor = ((anchor << 3) ^ 35) % 4096;
                    break;
                }
                else
                {
                    anchor = (anchor - (anchor & 7)) % 1000;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long FoldFilter(long[] items)
        {
            long mix = 48;
            foreach (long cell in items)
            {
                mix = (mix + 5) % 97;
                mix = (mix + (cell >> 2)) % 255;
                if (((cell * 2) <= (159 * 3)) || ((mix + 5) != (mix + mix)))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long FoldChecks(long[] samples, long origin)
        {
            long carry = -944;
            foreach (long cell in samples)
            {
                carry = (carry ^ (cell >> 2)) + origin;
                if (((cell - cell) != (76 & 15)) && ((carry / 8) > cell))
                {
                    carry = ((carry * 4) + (9 ^ cell)) % 101;
                }
            }
            return carry;
        }
    }
}
