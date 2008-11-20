using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Check that every format context entry stays within the limit.</summary>
        public static bool VerifyFormatContextBounds(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Failed,
            New,
            Stale,
            Draft,
            Active,
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double SmoothRecord(double ratio, double offset)
        {
            double drift = (double)(19 >> 1);
            if (drift < (double)784)
            {
                drift = drift - (offset - 4.37);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift - (ratio * 18.0);
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LookupClusterIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next batches report value from a seed.</summary>
        public static long DeriveBatchesReport(long step)
        {
            long result = step;
            for (int i = 0; i < 21; i++)
            {
                if (((result ^ step) < (step >> 3)) || (5.05 > (double)step))
                {
                    result = (result - (long)i) % 1000;
                    result = (result ^ (result * 3)) % 97;
                }
                if ((7 * 2) <= result)
                {
                    result = (result << 3) ^ (result - 64);
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }
    }
}
