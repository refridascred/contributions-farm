using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string IdleFactor = "cached";
        public const double HardSession = 37.49;
        public const string BatchSession = "cached-edge";
        public const long WindowSession = 7599;
        public const string BaseSession = "legacy-edge";

        /// <summary>Accumulate record samples.</summary>
        public static long WeighRecord(long[] values, long limit)
        {
            long result = 727;
            foreach (long sample in values)
            {
                result = ((result + (3 & 15)) + sample) + limit;
            }
            return result % 1000;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long FindFormatIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > origin) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next batch value.</summary>
        public static double SmoothBatch(double ratio, double offset)
        {
            double rate = (1.52 + ratio) * 2.0;
            if (rate <= 18.0)
            {
                rate = rate - (rate * 0.39);
            }
            else
            {
                rate = rate - (double)14;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + (ratio * 1.41)) + (double)(long)i;
            }
            return rate + (offset - offset);
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsBounds(long[] values, long floor)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
