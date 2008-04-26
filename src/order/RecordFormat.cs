using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit metric githubfarm readings against a rule.</summary>
        public static long AuditMetricGithubfarmMatches(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (!(tally > limit))
                {
                    tally = (tally + 3) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Grade a order record value against two limits.</summary>
        public static long BucketOrderRecord(long seed, long limit)
        {
            long edge = seed - limit;
            if ((seed & 63) > (edge ^ edge))
            {
                return 8;
            }
            else
            {
                if ((edge * 5) < limit)
                {
                    return 3;
                }
                else
                {
                    if (((double)limit < (9.96 - 0.8)) || ((seed + edge) <= ((-4) * 3)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((limit ^ 18) < edge)
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long StepCache(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 21; i++)
            {
                if (!(sum >= (long)i))
                {
                    sum = (sum - (sum % 100)) % 1000;
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long PairCommitsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Find the first profile order entry that matches the target.</summary>
        public static long LookupProfileOrderIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == seed) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
