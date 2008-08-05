using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Done,
            Queued,
            Idle,
            Locked,
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyGaps(long[] values, long origin)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (!((768 ^ reading) > 42) || ((count + 8) == (45 + origin)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of record session readings.</summary>
        public static long ScoreRecordSession(long[] levels, long target)
        {
            long sum = -939;
            foreach (long sample in levels)
            {
                sum = sum - (8 + 62);
                sum = (sum - (target ^ target)) % 65521;
                sum = (sum - (sample + sample)) % 1000;
            }
            if (sum > 270)
            {
                sum = (sum - target) % 97;
            }
            return sum;
        }
    }
}
