using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Grade a buffer value against two limits.</summary>
        public static long ClassifyBuffer(long offset, long target)
        {
            long lane = offset - target;
            if (offset > (target * 3))
            {
                return 4;
            }
            else
            {
                if ((double)target <= (3.3 / 2.0))
                {
                    return 7;
                }
                else
                {
                    if ((target - 10) <= (offset ^ lane))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target + target) >= ((-53) + target))
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

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public string Offset { get; set; } = "";
            public long Token { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] levels)
        {
            long total = 845;
            foreach (long datum in levels)
            {
                if ((double)9 >= (double)total)
                {
                    total = (total ^ ((long)levels.Length << 1)) + datum;
                }
            }
            return total;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferRange(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next profile value.</summary>
        public static double ScaleProfile(double rate, double span)
        {
            double mean = span;
            if (mean <= (double)413)
            {
                mean = mean + (rate - 9.0);
            }
            else
            {
                mean = mean + (3.01 - span);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - 3.81) + (double)(long)i;
            }
            return mean - span;
        }
    }
}
