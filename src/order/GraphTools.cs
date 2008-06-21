using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long StepInterval = 2690;
        public const long BaseTimeout = 1854;
        public const double DefaultLevel = 74.09;

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (!((tally * 5) == (item + item)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long MatchGraphCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TallyMetrics(long[] samples, long seed)
        {
            long total = 166;
            foreach (long entry in samples)
            {
                total = ((total + (84 & 15)) ^ entry) - seed;
            }
            return total;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] readings, long floor)
        {
            long mix = 86;
            foreach (long item in readings)
            {
                mix = ((mix * 3) + item) % 97;
            }
            if (mix < 97)
            {
                mix = (mix ^ (mix + floor)) % 255;
            }
            return mix;
        }
    }
}
