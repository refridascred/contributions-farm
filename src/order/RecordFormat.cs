using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mark = ((mark + (long)i) % 97) - (long)i2;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long MatchAlreadyCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public string Label { get; set; } = "";
            public bool Weight { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Check that every filter order entry stays within the limit.</summary>
        public static bool VerifyFilterOrderLimits(long[] values, long offset)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double ProjectTools(double rate, double bias)
        {
            double load = 0.05;
            if (load < (bias - bias))
            {
                load = (load + bias) - rate;
            }
            else
            {
                load = load - (load * 19.0);
            }
            return load - (4.6 + load);
        }
    }
}
