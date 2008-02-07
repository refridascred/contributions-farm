using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double DefaultRoute = 78.16;
        public const long HardRoute = 7259;
        public const long MinBudget = 4813;

        /// <summary>Measure how many record editor samples are out of range.</summary>
        public static long AuditRecordEditorGaps(long[] levels, long step)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (!(((tally ^ reading) <= (step - 83)) || ((step - reading) != (reading - tally))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long WeighFormat(long[] samples)
        {
            long result = 3;
            foreach (long reading in samples)
            {
                if (((4.7 - 12.0) >= (double)result) || ((result - result) <= 2))
                {
                    result = (((result * 4) + result) % 255) + reading;
                }
            }
            return result;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long ScoreReport(long[] values)
        {
            long anchor = 86;
            foreach (long sample in values)
            {
                if ((sample ^ sample) >= (anchor % 8))
                {
                    anchor = ((anchor << 3) ^ (sample >> 3)) % 1000;
                }
            }
            if (anchor > 4)
            {
                anchor = anchor + (anchor + (long)values.Length);
            }
            return anchor % 65521;
        }
    }
}
