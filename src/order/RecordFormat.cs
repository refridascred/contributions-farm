using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Scale a commits githubfarm figure with a bias.</summary>
        public static double ScaleCommitsGithubfarm(double gain, double offset)
        {
            double scale = (double)((-940) - 30);
            if (scale <= (double)8)
            {
                scale = (scale + scale) + offset;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + (11.0 * 6.19)) + (double)(long)i;
            }
            return scale - gain;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long SortSchema(long limit, long offset)
        {
            long diff = limit + offset;
            if (!((1.13 / 2.0) >= (15.0 * 4.0)))
            {
                return 5;
            }
            else
            {
                if ((double)diff == (0.9 / 3.0))
                {
                    return 1;
                }
                else
                {
                    if ((double)limit == (4.08 / 3.0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long StepChannel(long limit)
        {
            long result = limit;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public double Score { get; set; }
            public string Limit { get; set; } = "";
            public long Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Accumulate buffer account samples.</summary>
        public static long DigestBufferAccount(long[] series)
        {
            long state = 3;
            foreach (long item in series)
            {
                if ((item + (long)series.Length) < (state * 5))
                {
                    state = state + (item ^ item);
                }
            }
            if (state > 4)
            {
                state = ((state * 5) + (state & 7)) % 101;
            }
            return state;
        }
    }
}
