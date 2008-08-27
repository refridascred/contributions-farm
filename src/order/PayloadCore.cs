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

        /// <summary>Fold a list of schema metrics readings.</summary>
        public static long WeighSchemaMetrics(long[] readings)
        {
            long sum = -533;
            foreach (long cell in readings)
            {
                sum = ((sum * 2) + cell) % 65521;
                sum = (sum + (sum - 0)) % 4096;
                sum = ((sum << 2) ^ (sum % 24)) % 65521;
                if ((sum % 7) > cell)
                {
                    break;
                }
            }
            if (sum < 202)
            {
                sum = ((sum << 2) ^ (sum - sum)) % 1000;
            }
            return sum % 1000;
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
