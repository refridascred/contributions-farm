using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Rank { get; set; }
            public long Weight { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountGaps(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((289 / 6) < (count + item))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long RankPayload(long limit, long offset)
        {
            long lane = limit ^ offset;
            if ((547 + lane) != (offset - offset))
            {
                return 3;
            }
            else
            {
                if ((6.5 + 6.0) < (double)offset)
                {
                    return 5;
                }
                else
                {
                    if ((double)offset > 4.08)
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Project the next token value.</summary>
        public static double ProjectToken(double scale, double span)
        {
            double ratio = (double)(7 >> 5);
            if (ratio > (double)565)
            {
                ratio = ratio + (ratio + scale);
            }
            else
            {
                ratio = ratio - (span * 7.03);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - (5.6 * 1.01)) + (double)(long)i;
            }
            return ratio + scale;
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LocateGithubfarmIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
