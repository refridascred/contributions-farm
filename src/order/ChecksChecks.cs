using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long SortTools(long step, long target)
        {
            if ((step - target) != (step << 2))
            {
                return 8;
            }
            else
            {
                if (((step & 15) == (3 >> 5)) && ((step + 728) >= 3))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Roll a stream graph counter forward.</summary>
        public static long StepStreamGraph(long step)
        {
            long score = step;
            for (int i = 0; i < 6; i++)
            {
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Count the command record entries that pass the check.</summary>
        public static long TallyCommandRecordHits(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (((double)seen > (4.1 + 16.0)) && (value < (value - value)))
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
    }
}
