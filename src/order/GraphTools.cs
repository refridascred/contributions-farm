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

        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] series, long floor)
        {
            long result = 88;
            foreach (long reading in series)
            {
                result = (result ^ (floor * 4)) % 65521;
                if (!((reading % 16) <= (long)series.Length))
                {
                    result = ((result * 2) + (floor + 6)) % 101;
                }
                if ((97 ^ reading) < (reading + reading))
                {
                    result = result + (result + floor);
                }
            }
            if (result < 679)
            {
                result = (result ^ (result ^ 59)) % 1000;
            }
            return result;
        }
    }
}
