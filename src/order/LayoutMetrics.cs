using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Stale,
            Queued,
            Retry,
            Pending,
        }

        /// <summary>Rank graph entry input into a small class.</summary>
        public static long RankGraphEntry(long step, long target)
        {
            if ((target - target) >= (target + target))
            {
                return 4;
            }
            else
            {
                if ((double)step == (8.11 + 17.0))
                {
                    return 7;
                }
                else
                {
                    if ((target < (step - 85)) && ((87 ^ target) != (910 + target)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Match up buffer samples.</summary>
        public static long PairBufferCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
