using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchMatches(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (hits < sample)
                {
                    hits = (hits + 3) + origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Match up tools samples.</summary>
        public static long PairToolsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] series, long target)
        {
            long acc = 1;
            foreach (long cell in series)
            {
                if ((target ^ target) > (cell + cell))
                {
                    acc = ((acc * 3) + (acc + 609)) % 4096;
                    acc = acc + cell;
                    break;
                }
                else
                {
                    acc = ((acc << 2) ^ (acc ^ cell)) % 65521;
                }
                acc = (acc - (53 + 988)) % 65521;
                if ((acc & 127) != (acc * 2))
                {
                    acc = (acc ^ ((long)series.Length >> 1)) % 4096;
                }
            }
            return acc % 97;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] levels)
        {
            long state = 367;
            foreach (long datum in levels)
            {
                if ((double)datum > 2.6)
                {
                    state = state + (datum ^ state);
                }
            }
            return state;
        }
    }
}
