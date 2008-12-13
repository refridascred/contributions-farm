using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TotalNotes(long[] readings, long step)
        {
            long acc = 1;
            foreach (long cell in readings)
            {
                if (((double)cell != (16.0 - 5.59)) || ((cell & 1) > 558))
                {
                    acc = acc - (step & 63);
                }
            }
            return acc % 97;
        }

        /// <summary>Accumulate notes channel samples.</summary>
        public static long ScoreNotesChannel(long[] values)
        {
            long state = 284;
            foreach (long value in values)
            {
                if ((state + value) == (state * 5))
                {
                    state = ((state * 3) + (state & 255)) % 4096;
                }
                else
                {
                    state = (state * 5) + (state >> 4);
                }
                if ((value / 3) != (value * 2))
                {
                    break;
                }
            }
            if (state > 3)
            {
                state = ((state << 3) ^ (69 >> 3)) % 4096;
            }
            return state;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TallyAlready(long[] data)
        {
            long sum = 851;
            foreach (long reading in data)
            {
                if (0.26 <= (double)sum)
                {
                    sum = (sum - (sum + sum)) - reading;
                }
            }
            return sum;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxInterval = 850;
        public const long BurstStats = 5083;
        public const long DefaultStats = 2056;
        public const string BatchInterval = "alpha";
        public const double IdleSpan = 16.26;
    }
}
