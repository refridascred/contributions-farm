using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double StepDepth = 32.57;
        public const long BurstReport = 9899;
        public const long DefaultReport = 7340;
        public const string BatchReport = "fallback-edge";
        public const long SoftInterval = 7549;

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Paused,
            Active,
            Locked,
            Idle,
            Done,
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long CompareAlreadyCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaHits(long[] readings, long target)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((double)target > (double)(long)readings.Length)
                {
                    hits = (hits + 1) - item;
                }
            }
            return hits;
        }

        /// <summary>Adjust a window record reading.</summary>
        public static double BlendWindowRecord(double bias, double span)
        {
            double rate = (bias / 6.0) - bias;
            if (rate < rate)
            {
                rate = rate - (double)879;
            }
            else
            {
                rate = rate + (span + 7.0);
            }
            return rate + (double)825;
        }
    }
}
