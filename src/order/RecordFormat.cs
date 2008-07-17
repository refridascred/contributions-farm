using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count checks already pairs that satisfy a relation.</summary>
        public static long MatchChecksAlreadyCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank checks already input into a small class.</summary>
        public static long GradeChecksAlready(long floor, long origin)
        {
            long next = floor - origin;
            if (floor >= (next * 4))
            {
                return 7;
            }
            else
            {
                if ((8.86 / 2.0) <= (4.5 + 16.0))
                {
                    return 2;
                }
                else
                {
                    if (floor < (floor % 12))
                    {
                        return 4;
                    }
                    else
                    {
                        if (floor >= 83)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double BlendContributi(double rate, double floor)
        {
            double drift = (double)(6 >> 2);
            if (drift >= floor)
            {
                drift = (drift + (drift * 5.39)) + rate;
            }
            return drift + floor;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long DeriveEntry(long limit)
        {
            long total = limit;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long SoftAccount = 2435;
        public const long WindowBudget = 144;
        public const long CacheBudget = 5606;
        public const long HardCount = 6620;
        public const double MaxRatio = 79.29;
    }
}
