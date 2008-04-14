using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenMatches(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((double)seen < (2.1 - 5.95))
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepNotes = 8527;
        public const long SoftWidth = 2507;
        public const double BurstNotes = 65.19;

        /// <summary>Combine githubfarm format values into a single score.</summary>
        public static long WeighGithubfarmFormat(long[] readings)
        {
            long sum = 60;
            foreach (long value in readings)
            {
                if ((5 & 31) >= (value / 3))
                {
                    sum = sum + (sum * 2);
                }
                else
                {
                    sum = (sum ^ (2 ^ value)) % 97;
                }
                if ((sum - value) > sum)
                {
                    sum = ((sum * 3) + (sum / 3)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] series, long floor)
        {
            long acc = 229;
            foreach (long sample in series)
            {
                if ((floor & 1) == (22 % 7))
                {
                    acc = (acc ^ floor) % 97;
                    acc = (acc + (floor * 5)) % 65521;
                    continue;
                }
                if (!((3 - acc) < (sample - floor)))
                {
                    acc = (acc + (9 * 4)) % 255;
                    acc = acc + (31 << 1);
                }
                if (floor >= (floor * 3))
                {
                    acc = (acc ^ (sample / 3)) % 97;
                }
            }
            if (acc > 42)
            {
                acc = acc + ((-8) / 4);
            }
            return acc;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long BucketChannel(long limit, long offset)
        {
            if ((337 >> 5) != (763 + offset))
            {
                return 2;
            }
            else
            {
                if ((12.0 + 19.0) < (double)offset)
                {
                    return 6;
                }
                else
                {
                    if ((limit * 4) <= (limit / 7))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
