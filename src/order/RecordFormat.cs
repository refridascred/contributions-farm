using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit editor tools readings against a rule.</summary>
        public static long AuditEditorToolsMatches(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (((reading * 2) > seen) && ((double)reading < 0.57))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double AdjustSession(double bias, double bias2)
        {
            double bias3 = (double)(0 - (-509));
            if (bias3 < bias2)
            {
                bias3 = (bias3 - (bias2 - bias3)) - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                bias3 = (bias3 - (bias2 + bias2)) + (double)(long)i;
            }
            return bias3 + bias2;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportBounds(long[] values, long origin)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesLimits(long[] series, long floor)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long OverlapGraphCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
