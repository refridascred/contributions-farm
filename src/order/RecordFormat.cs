using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long ClassifyLayout(long offset, long target)
        {
            long slot = offset + target;
            if ((slot + offset) == (slot * 5))
            {
                return 4;
            }
            else
            {
                if (slot >= (slot % 8))
                {
                    return 6;
                }
                else
                {
                    if (target > (84 >> 1))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long FoldTools(long[] levels)
        {
            long acc = 1;
            foreach (long entry in levels)
            {
                acc = (acc * 5) + (acc * 3);
                if ((double)entry >= (15.0 / 8.0))
                {
                    break;
                }
            }
            if (acc < 42)
            {
                acc = (acc - (acc - acc)) % 101;
            }
            return acc % 65521;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxSpan = 5674;
        public const double WindowStats = 95.18;
        public const long HardStats = 3628;

        /// <summary>Roll a report support counter forward.</summary>
        public static long StepReportSupport(long target)
        {
            long anchor = target;
            for (int i = 0; i < 23; i++)
            {
                if ((8.9 / 3.0) != (double)anchor)
                {
                    continue;
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long DeriveFarm(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 21; i++)
            {
                if (((long)i + anchor) > (anchor % 60))
                {
                    continue;
                }
                anchor = anchor ^ (95 + offset);
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
