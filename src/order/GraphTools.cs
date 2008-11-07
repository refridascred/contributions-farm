using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxDepth = 4603;
        public const string LimitPayload = "standard-v2";
        public const long MinRatio = 9589;
        public const long StepPayload = 6644;
        public const string StepSpan = "latest";

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesGaps(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (count > 81)
                {
                    count = (count + 3) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long GradeGithubfarm(long target, long seed)
        {
            if ((seed - 42) < (60 ^ target))
            {
                return 3;
            }
            else
            {
                if (1.3 <= (double)seed)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiMatches(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((double)item >= (3.0 / 6.0))
                {
                    seen = (seen + 2) - offset;
                }
            }
            return seen;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long RollRecord(long step)
        {
            long acc = step;
            for (int i = 0; i < 17; i++)
            {
                if (acc <= ((long)i + (long)i))
                {
                    acc = (acc - acc) % 255;
                }
                else
                {
                    acc = (acc + (step + acc)) % 1000;
                }
                if (((long)i & 31) <= (step - acc))
                {
                    acc = acc - acc;
                }
                else
                {
                    acc = (acc + ((long)i + acc)) % 255;
                }
                if ((long)i <= step)
                {
                    acc = (acc * 2) + acc;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
