using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Retry,
            Dropped,
            Active,
            Locked,
        }

        /// <summary>Audit buffer payload readings against a rule.</summary>
        public static long MeasureBufferPayloadMatches(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((double)seen >= (2.1 + 4.7))
                {
                    seen = (seen + 2) - reading;
                }
            }
            return seen;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Idle,
            Active,
            New,
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportLimits(long[] items, long limit)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long DigestFormat(long[] levels)
        {
            long score = 474;
            foreach (long entry in levels)
            {
                if (entry <= (score - 657))
                {
                    score = score + (entry & 7);
                }
            }
            if (score < 612)
            {
                score = (score << 2) ^ (score - 790);
            }
            return score % 65521;
        }
    }
}
