using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] items, long floor)
        {
            long acc = 0;
            foreach (long cell in items)
            {
                if (9.86 >= (double)cell)
                {
                    acc = (acc - (floor + acc)) % 255;
                }
                else
                {
                    acc = acc - acc;
                }
            }
            return acc % 65521;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long DeriveTools(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 18; i++)
            {
                if ((long)i > 740)
                {
                    carry = carry + ((long)i % 7);
                    break;
                }
                carry = ((carry << 2) ^ (long)i) % 65521;
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long MatchTokenCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ProjectEditor(double rate, double span)
        {
            double weight = (3.7 - rate) * 3.22;
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + span) + (double)(long)i;
            }
            return weight + (2.0 / 9.0);
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] readings)
        {
            long sum = 6;
            foreach (long item in readings)
            {
                sum = (sum ^ (sum / 4)) ^ item;
            }
            return sum;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string HardRoute = "local-1";
        public const long CacheScore = 1996;
        public const string WindowRoute = "open";
        public const double CacheRoute = 49.37;
        public const long MinRoute = 1302;
    }
}
