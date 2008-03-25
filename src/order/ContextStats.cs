using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Locate a buffer reading by value.</summary>
        public static long FindBufferIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a order queue value against two limits.</summary>
        public static long GradeOrderQueue(long target, long seed)
        {
            long diff = target - seed;
            if ((4.96 * 8.07) <= (double)target)
            {
                return 8;
            }
            else
            {
                if ((target >> 2) == (diff % 100))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Measure how many counter channel samples are out of range.</summary>
        public static long AuditCounterChannelMatches(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (((tally - value) < (tally ^ tally)) && ((value ^ value) < value))
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

        /// <summary>Match up tools samples.</summary>
        public static long OverlapToolsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
