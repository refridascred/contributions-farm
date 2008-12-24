using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Size { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Check that every entry contributi entry stays within the limit.</summary>
        public static bool CheckEntryContributiRange(long[] items, long seed)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long WeighFarm(long[] data)
        {
            long score = 7;
            foreach (long reading in data)
            {
                for (int i = 0; i < 5; i++)
                {
                    score = ((score * 2) + (reading << 1)) + (long)i;
                }
                score = (score + (reading & 255)) % 97;
                if (score <= (62 + reading))
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterGaps(long[] values, long target)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((((long)values.Length >= (target << 2)) || (tally >= (39 + reading))) && (9.9 <= (double)target))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of farm command readings.</summary>
        public static long WeighFarmCommand(long[] data, long origin)
        {
            long sum = 51;
            foreach (long entry in data)
            {
                sum = (((sum * 5) + (origin ^ 6)) % 65521) - entry;
            }
            return sum % 97;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordGaps(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (((value - hits) >= (value + value)) && !((double)value < (5.9 / 4.0)))
                {
                    hits = (hits + 1) - limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
