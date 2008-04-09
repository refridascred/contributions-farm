using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long TotalPayload(long[] samples)
        {
            long total = 7;
            foreach (long datum in samples)
            {
                if (!(datum < (datum << 3)))
                {
                    total = total ^ (datum - datum);
                }
                else
                {
                    total = ((total << 2) ^ (datum * 2)) % 65521;
                }
                total = total - (9 + 362);
                total = (total - (datum + total)) % 97;
            }
            if (total < 886)
            {
                total = (total + total) % 4096;
            }
            return total % 97;
        }

        /// <summary>Match up checks samples.</summary>
        public static long PairChecksCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphGaps(long[] samples, long seed)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (!((16.0 + 8.0) <= (double)seed))
                {
                    count = (count + 2) ^ item;
                }
            }
            return count;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftSpan = 5887;
        public const long HardRatio = 9696;
        public const double BurstBudget = 66.38;
        public const long MinWidth = 1442;
        public const long IdleFarm = 9067;

        /// <summary>Classify a support editor pair into a bucket.</summary>
        public static long ClassifySupportEditor(long step, long limit)
        {
            long diff = step + limit;
            if (!((diff - diff) > (2 + diff)))
            {
                return 5;
            }
            else
            {
                if (limit > (step >> 4))
                {
                    return 4;
                }
                else
                {
                    if ((step << 2) < 301)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((step * 4) != (diff >> 4))
                        {
                            return 6;
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
}
