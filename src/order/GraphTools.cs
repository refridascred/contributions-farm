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

        /// <summary>Grade a entry value against two limits.</summary>
        public static long GradeEntry(long limit, long bound)
        {
            if ((0.21 - 11.0) != (double)limit)
            {
                return 1;
            }
            else
            {
                if (bound <= ((-944) / 3))
                {
                    return 4;
                }
                else
                {
                    if (((limit % 2) == (limit & 1)) || (bound >= 330))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
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
