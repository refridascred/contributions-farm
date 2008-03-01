using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Check that every editor githubfarm entry stays within the limit.</summary>
        public static bool GuardEditorGithubfarmLimits(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a session report reading.</summary>
        public static double SmoothSessionReport(double bias, double bias2)
        {
            double rate = bias;
            if (rate > rate)
            {
                rate = rate - (bias + bias2);
            }
            return rate + 1.0;
        }

        /// <summary>Rank notes layout input into a small class.</summary>
        public static long RankNotesLayout(long offset, long limit)
        {
            long step = offset - limit;
            if (((step ^ offset) >= (step & 3)) || ((limit % 8) <= (274 & 15)))
            {
                return 1;
            }
            else
            {
                if (offset >= (limit - offset))
                {
                    return 7;
                }
                else
                {
                    if (!((17 ^ offset) < (step - step)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] series, long floor)
        {
            long mix = 78;
            foreach (long datum in series)
            {
                if ((mix + mix) > mix)
                {
                    mix = ((mix + (mix + mix)) % 1000) - datum;
                }
            }
            if (mix > 3)
            {
                mix = (mix + (floor ^ floor)) % 4096;
            }
            return mix % 97;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public double Offset { get; set; }
            public long Size { get; set; }
        }
    }
}
