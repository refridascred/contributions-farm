using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Find the first checks cluster entry that matches the target.</summary>
        public static long FindChecksClusterIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepRatio = 1057;
        public const long SoftCache = 9906;
        public const long SoftSize = 2703;
        public const long MaxCache = 6788;
        public const long BatchCache = 7377;

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteGaps(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (((tally >= (437 + tally)) && ((tally - tally) == (tally + reading))) || ((reading ^ tally) > (tally >> 3)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryLimits(long[] items, long step)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
