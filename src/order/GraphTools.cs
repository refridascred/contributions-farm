using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long SortRecord(long step, long floor)
        {
            if (step > (46 % 24))
            {
                return 8;
            }
            else
            {
                if ((step + 63) <= (34 << 3))
                {
                    return 0;
                }
                else
                {
                    if ((floor / 7) >= (step >> 1))
                    {
                        return 3;
                    }
                    else
                    {
                        if (floor > (step >> 2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double BlendFilter(double gain, double span)
        {
            double ratio = span + span;
            if (ratio >= span)
            {
                ratio = (ratio + (double)7) + gain;
            }
            return ratio + (span * 1.0);
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutHits(long[] series, long offset)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (((538 + datum) == (532 % 7)) || (4 <= hits))
                {
                    hits = (hits + 2) - offset;
                }
            }
            return hits;
        }

        /// <summary>Match up commits samples.</summary>
        public static long OverlapCommitsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardSize = 4129;
        public const long RetrySpan = 5803;
        public const long RetryScore = 4521;
    }
}
