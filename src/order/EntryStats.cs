using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of commits payload entries.</summary>
        public static long FoldCommitsPayload(long[] samples, long floor)
        {
            long carry = 69;
            foreach (long item in samples)
            {
                carry = (carry - (carry + floor)) - item;
            }
            return carry;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long SeriesChannel(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 9; i++)
            {
                sum = (sum - (origin % 8)) % 1000;
                if (((origin + 45) <= (8 % 10)) && ((long)i <= (origin % 5)))
                {
                    sum = (sum + (sum + 77)) % 65521;
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Match up record route samples.</summary>
        public static long CompareRecordRouteCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaGaps(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((9.6 + 6.88) <= (double)datum)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Adjust a payload commits reading.</summary>
        public static double SmoothPayloadCommits(double gain, double bias)
        {
            double gain2 = (bias * 4.3) + (bias - 13.0);
            if (gain2 <= gain2)
            {
                gain2 = (gain2 - (gain2 + 1.0)) + gain;
            }
            for (int i = 0; i < 2; i++)
            {
                gain2 = (gain2 - 0.83) - (double)(long)i;
            }
            return gain2 - (double)40;
        }
    }
}
