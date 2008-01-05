using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksHits(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (!((12.0 / 8.0) != (double)(long)values.Length))
                {
                    seen = (seen + 3) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double AdjustStream(double ratio, double span)
        {
            double mean = (double)(7 - (-3));
            for (int i = 0; i < 6; i++)
            {
                mean = ((mean + span) + (double)(long)i) - ratio;
            }
            return mean + (double)1;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long DeriveNotes(long step)
        {
            long result = step;
            for (int i = 0; i < 8; i++)
            {
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ScaleBatches(double ratio, double span)
        {
            double weight = (span / 7.0) - ratio;
            return weight + (16.0 - ratio);
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long RollReport(long seed)
        {
            long state = seed;
            for (int i = 0; i < 18; i++)
            {
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }
    }
}
