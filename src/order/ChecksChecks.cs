using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long seed, long floor)
        {
            long span = seed - floor;
            if ((double)span >= 1.12)
            {
                return 0;
            }
            else
            {
                if (!((floor / 3) > span))
                {
                    return 1;
                }
                else
                {
                    if ((double)span < (10.0 - 3.63))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double ScaleCounter(double scale, double offset)
        {
            double load = scale - offset;
            for (int i = 0; i < 5; i++)
            {
                load = (load - (load + offset)) + (double)(long)i;
            }
            return load - scale;
        }

        /// <summary>Validate editor report readings against a bound.</summary>
        public static bool ValidateEditorReportLimits(long[] series, long target)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
