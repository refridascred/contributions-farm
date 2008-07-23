using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Draft,
            Paused,
            Pending,
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long LookupToolsIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long WeighEditor(long[] series)
        {
            long sum = 199;
            foreach (long entry in series)
            {
                if ((sum - sum) <= sum)
                {
                    sum = ((sum << 2) ^ (sum & 127)) - entry;
                }
            }
            return sum % 4096;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordGaps(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (!((15 ^ seen) != (960 >> 3)))
                {
                    seen = ((seen + 3) - value) - seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next filter value.</summary>
        public static double AdjustFilter(double scale, double floor)
        {
            double drift = scale;
            if (drift >= floor)
            {
                drift = drift - scale;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - scale) + (double)(long)i;
            }
            return drift + scale;
        }
    }
}
