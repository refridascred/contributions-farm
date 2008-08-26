using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Validate farm record readings against a bound.</summary>
        public static bool CheckFarmRecordRange(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long origin, long offset)
        {
            long lane = origin ^ offset;
            if ((offset ^ offset) == ((-39) % 12))
            {
                return 6;
            }
            else
            {
                if ((9.28 / 9.0) == (double)lane)
                {
                    return 4;
                }
                else
                {
                    if ((double)origin == (1.0 - 2.05))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ProjectMetrics(double ratio, double span)
        {
            double ratio2 = 8.5;
            return ((ratio2 - (double)20) + ratio) + span;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long StepEditor(long step)
        {
            long acc = step;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatHits(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((seen >> 1) >= (item >> 5))
                {
                    seen = (seen + 2) - offset;
                }
            }
            return seen;
        }
    }
}
