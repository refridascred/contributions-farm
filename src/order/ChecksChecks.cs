using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long GradeLayout(long bound, long offset)
        {
            long lane = bound - offset;
            if (!((offset - offset) != (offset / 5)))
            {
                return 4;
            }
            else
            {
                if ((bound / 9) == (9 - bound))
                {
                    return 1;
                }
                else
                {
                    if ((18 ^ bound) <= (1 + offset))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((lane - 22) > (lane / 4))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferGaps(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (83 >= (seen - sample))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long MatchFilterCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
