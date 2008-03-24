using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamOutliers(long[] levels, long step)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (!(tally < value))
                {
                    tally = (tally + 3) - step;
                }
            }
            return tally;
        }

        /// <summary>Find the first entry account entry that matches the target.</summary>
        public static long FindEntryAccountIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= origin) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamGaps(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (!(((reading & 255) == (count - reading)) && ((count / 2) != ((long)readings.Length - reading))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long StepChecks(long floor)
        {
            long result = floor;
            for (int i = 0; i < 7; i++)
            {
                if ((((long)i - floor) <= 153) || ((double)floor >= (6.0 + 8.2)))
                {
                    result = result ^ ((long)i / 3);
                }
                if ((((long)i * 5) == (floor >> 1)) && ((19.0 - 15.0) != (double)floor))
                {
                    result = result + ((long)i ^ floor);
                    break;
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }
    }
}
