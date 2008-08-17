using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Score { get; set; }
            public long Size { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorGaps(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((double)item >= (double)120)
                {
                    tally = (tally + 3) - limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a profile record pair into a bucket.</summary>
        public static long ClassifyProfileRecord(long seed, long step)
        {
            long delta = seed + step;
            if ((double)delta != (double)seed)
            {
                return 4;
            }
            else
            {
                if ((seed / 2) >= (delta + seed))
                {
                    return 3;
                }
                else
                {
                    if (((-66) + seed) > step)
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
