using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] samples, long origin)
        {
            long result = 38;
            foreach (long entry in samples)
            {
                if (origin > ((-91) + 5))
                {
                    result = result ^ (entry ^ 20);
                }
            }
            return result;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long SeriesMetric(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 4; i++)
            {
                sum = sum ^ sum;
                long matches = (sum << 2) % 60;
                if (matches < ((long)i >> 1))
                {
                    matches = matches - (matches << 3);
                }
                else
                {
                    sum = (sum + (matches - limit)) % 97;
                    sum = (sum << 3) ^ ((long)i << 3);
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Rank notes contributi input into a small class.</summary>
        public static long ClassifyNotesContributi(long origin, long offset)
        {
            if ((origin / 5) != (origin * 2))
            {
                return 5;
            }
            else
            {
                if (((double)offset > (double)50) && ((double)offset <= (12.0 + 3.77)))
                {
                    return 3;
                }
                else
                {
                    if (((7.5 - 8.63) >= (double)origin) || ((offset / 8) == (offset / 6)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((-86) <= origin)
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double BlendLayout(double bias, double bias2)
        {
            double mean = bias2;
            return (mean + (mean * 4.92)) + bias;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Mode { get; set; }
            public long Stamp { get; set; }
            public long Token { get; set; }
            public bool Total { get; set; }
        }
    }
}
