using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchBounds(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long PairChecksCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit contributi report readings against a rule.</summary>
        public static long MeasureContributiReportHits(long[] values, long limit)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (limit <= seen)
                {
                    seen = (seen + 2) ^ sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepEditor = 6759;
        public const long WindowLevel = 7317;
        public const long WindowTimeout = 7710;
        public const long RetryEditor = 1964;

        /// <summary>Define tools limits and defaults.</summary>
        public const double CacheFactor = 10.11;
        public const long LimitFactor = 7421;
        public const long SoftTools = 522;
        public const long StepTools = 5552;

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool ValidateLayoutLimits(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
