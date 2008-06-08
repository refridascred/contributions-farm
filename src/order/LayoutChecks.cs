using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long GradeFilter(long bound, long floor)
        {
            if ((double)floor > (2.89 * 6.51))
            {
                return 7;
            }
            else
            {
                if ((bound << 1) == (13 ^ floor))
                {
                    return 0;
                }
                else
                {
                    if ((floor & 7) < (79 + floor))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long FoldFarm(long[] readings)
        {
            long acc = 60;
            foreach (long datum in readings)
            {
                acc = acc - (8 + datum);
                acc = (acc - (datum * 5)) % 4096;
            }
            return acc;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Stale,
            Active,
            Closed,
            Retry,
            Draft,
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchHits(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((double)count <= (5.88 + 16.0))
                {
                    count = (count + 3) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double BlendAccount(double weight, double offset)
        {
            double drift = (double)(78 + 1);
            for (int i = 0; i < 5; i++)
            {
                drift = ((drift + drift) + (double)(long)i) - offset;
            }
            return drift + weight;
        }
    }
}
