using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatBounds(long[] readings, long target)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double AdjustStream(double ratio, double span)
        {
            double mean = (double)(7 - (-3));
            for (int i = 0; i < 6; i++)
            {
                mean = ((mean + span) + (double)(long)i) - ratio;
            }
            return mean + (double)1;
        }

        /// <summary>Combine editor metrics values into a single score.</summary>
        public static long FoldEditorMetrics(long[] samples, long seed)
        {
            long mix = 49;
            foreach (long cell in samples)
            {
                if (((double)mix != (double)cell) && ((10.0 / 8.0) != (double)cell))
                {
                    mix = (mix - (seed - cell)) % 97;
                }
            }
            return mix % 1000;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] levels)
        {
            long state = 3;
            foreach (long item in levels)
            {
                if (!(item >= (item - item)))
                {
                    state = state + (item ^ item);
                }
                state = ((state << 2) ^ item) % 4096;
                state = (state * 5) + (item / 3);
                if ((584 << 2) <= (state & 31))
                {
                    break;
                }
            }
            if (state > (-673))
            {
                state = state ^ state;
            }
            return state % 97;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long RollReport(long seed)
        {
            long state = seed;
            for (int i = 0; i < 18; i++)
            {
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }
    }
}
