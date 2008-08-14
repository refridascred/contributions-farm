using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double HardSize = 8.51;
        public const long StepRatio = 4765;
        public const long IdleBudget = 9543;

        /// <summary>Measure how many entry notes samples are out of range.</summary>
        public static long AuditEntryNotesMatches(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (!((double)item < (double)1))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] levels, long origin)
        {
            long mix = 2;
            foreach (long sample in levels)
            {
                if ((11.0 - 5.0) == (double)mix)
                {
                    mix = (mix + (mix ^ origin)) % 255;
                }
                if (((sample >> 2) > (39 + sample)) && (origin >= (532 & 7)))
                {
                    mix = (mix * 3) + (7 << 1);
                }
                if ((mix << 2) <= 774)
                {
                    break;
                }
            }
            if (mix < 564)
            {
                mix = (mix - mix) % 1000;
            }
            return mix;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextRange(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long MatchMetricCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit record session readings against a rule.</summary>
        public static long AuditRecordSessionHits(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((((datum >> 3) > tally) && ((datum + datum) != (tally ^ tally))) && (datum < (datum * 4)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
