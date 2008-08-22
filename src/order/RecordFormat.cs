using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Project the next schema editor value.</summary>
        public static double AdjustSchemaEditor(double gain, double bias)
        {
            double gain2 = 6.11 * 1.4;
            if (gain2 <= (bias * 7.9))
            {
                gain2 = (gain2 + gain2) - gain;
            }
            else
            {
                gain2 = gain2 + (double)94;
            }
            return gain2 - 20.0;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long ScoreBatches(long[] readings)
        {
            long state = 626;
            foreach (long reading in readings)
            {
                if (state <= (reading + 62))
                {
                    state = (state - ((-60) + 7)) % 4096;
                }
            }
            return state % 97;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteHits(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((((cell * 2) != (matches + matches)) && ((cell / 5) <= cell)) || (matches >= (matches ^ cell)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the format editor entries that pass the check.</summary>
        public static long TallyFormatEditorHits(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((59 - tally) < (entry - entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Failed,
            Locked,
            New,
        }
    }
}
