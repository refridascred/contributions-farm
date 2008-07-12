using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long PairGraphCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a payload notes figure with a bias.</summary>
        public static double BlendPayloadNotes(double bias, double floor)
        {
            double bias2 = 2.09;
            if (bias2 <= (bias / 2.0))
            {
                bias2 = bias2 + (double)541;
            }
            else
            {
                bias2 = bias2 - 9.0;
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 + (bias2 + floor)) - (double)(long)i;
            }
            return bias2 - (bias2 * 5.02);
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Pending,
            Closed,
            New,
            Draft,
        }

        /// <summary>Compare every pair of report support readings.</summary>
        public static long OverlapReportSupportCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsMatches(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (((8 - 999) > (origin + sample)) || (((double)origin >= (7.11 + 18.0)) && ((double)seen != (double)sample)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
