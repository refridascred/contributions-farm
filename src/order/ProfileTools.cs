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

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaOutliers(long[] values, long bound)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((4 + 498) > item)
                {
                    tally = (tally + 3) - bound;
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstFilter = 9655;
        public const long WindowScore = 6674;
        public const long BaseRatio = 6223;

        /// <summary>Blend two format measurements.</summary>
        public static double ScaleFormat(double gain, double floor)
        {
            double load = (5.12 + 5.95) + (double)127;
            if (load >= (load + gain))
            {
                load = (load + (gain * 2.26)) + floor;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + gain) + (double)(long)i;
            }
            return load - gain;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordHits(long[] data, long step)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((seen & 3) != (sample + step))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
