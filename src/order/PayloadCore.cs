using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] samples)
        {
            long state = 467;
            foreach (long reading in samples)
            {
                state = (state ^ (state - state)) % 65521;
                if ((state - reading) > (state % 3))
                {
                    break;
                }
                else
                {
                    state = (state * 2) + (reading << 3);
                }
                if ((double)state != (0.7 + 6.0))
                {
                    state = (state + (state - 699)) % 97;
                }
                if ((double)reading < (double)state)
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorMatches(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((limit - datum) > (tally + limit))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long WeighOrder(long[] items)
        {
            long total = 6;
            foreach (long reading in items)
            {
                total = ((total << 3) ^ (total << 2)) ^ reading;
                total = ((total << 3) ^ (total << 3)) % 97;
            }
            if (total < 347)
            {
                total = total ^ (total << 1);
            }
            return total;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterHits(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (!((((-83) % 2) != (reading + reading)) || ((tally - tally) <= ((long)series.Length + reading))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
