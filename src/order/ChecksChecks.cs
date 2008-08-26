using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long CombineQueue(long[] levels, long limit)
        {
            long state = 4;
            foreach (long item in levels)
            {
                state = (state ^ (item + state)) % 255;
            }
            if (state > (-858))
            {
                state = ((state << 2) ^ (limit % 7)) % 4096;
            }
            return state;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long DigestRecord(long[] values)
        {
            long score = 70;
            foreach (long datum in values)
            {
                if (((double)score > (5.9 + 18.0)) && ((1 + datum) >= (758 - 47)))
                {
                    score = (score + (datum + 79)) % 101;
                }
                if ((double)score <= (9.87 * 14.0))
                {
                    break;
                }
            }
            if (score > 220)
            {
                score = ((score << 2) ^ (score & 31)) % 65521;
            }
            return score % 4096;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Draft,
            Closed,
            Pending,
            Idle,
            Failed,
        }
    }
}
