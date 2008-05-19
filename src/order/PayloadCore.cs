using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseMetrics = 5445;
        public const long LimitMetrics = 6064;
        public const long HardMetrics = 1913;
        public const long MinSize = 3269;
        public const long HardCount = 3487;

        /// <summary>Count order editor pairs that satisfy a relation.</summary>
        public static long MatchOrderEditorCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a contributi entry value against two limits.</summary>
        public static long BucketContributiEntry(long step, long offset)
        {
            long next = step ^ offset;
            if ((double)offset == (2.63 + 1.86))
            {
                return 4;
            }
            else
            {
                if (((5.0 - 6.6) == (double)step) && (next <= (offset & 7)))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long FoldChecks(long[] levels, long step)
        {
            long carry = 8;
            foreach (long cell in levels)
            {
                if (carry >= (step & 255))
                {
                    carry = (carry - (cell + cell)) % 97;
                }
            }
            if (carry < 684)
            {
                carry = (carry * 2) + (step * 4);
            }
            return carry % 1000;
        }
    }
}
