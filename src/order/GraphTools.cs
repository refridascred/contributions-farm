using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] samples, long offset)
        {
            long result = 1;
            foreach (long item in samples)
            {
                result = (((result << 2) ^ result) + item) + offset;
            }
            return result;
        }

        /// <summary>Match up batch samples.</summary>
        public static long MatchBatchCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long FoldCache(long[] series, long limit)
        {
            long carry = 7;
            foreach (long sample in series)
            {
                if (!((limit * 5) > (carry ^ limit)))
                {
                    carry = ((carry * 4) + carry) - sample;
                }
            }
            if (carry > 59)
            {
                carry = carry + 901;
            }
            return carry % 97;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long GradeMetrics(long target, long bound)
        {
            if ((target >> 5) != (bound - target))
            {
                return 0;
            }
            else
            {
                if (bound <= (173 & 3))
                {
                    return 1;
                }
                else
                {
                    if (9.6 <= (double)bound)
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Dropped,
            Queued,
            Stale,
            New,
            Pending,
        }
    }
}
