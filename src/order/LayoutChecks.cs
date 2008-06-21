using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count the checks session entries that pass the check.</summary>
        public static long AuditChecksSessionHits(long[] series, long step)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (6 >= matches)
                {
                    matches = ((matches + 1) - entry) + step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double BlendRecord(double rate, double bias)
        {
            double bias2 = rate;
            if (bias2 > 9.01)
            {
                bias2 = (bias2 - (double)(-81)) + bias;
            }
            return bias2 - (bias2 / 5.0);
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long target, long step)
        {
            long offset = target - step;
            if (((offset >> 2) >= (step % 64)) || ((11.0 * 8.0) != (double)target))
            {
                return 4;
            }
            else
            {
                if (target < (step ^ 263))
                {
                    return 6;
                }
                else
                {
                    if ((target >= (step & 127)) && ((offset ^ step) > offset))
                    {
                        return 2;
                    }
                    else
                    {
                        if (target > (target / 7))
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

        /// <summary>Roll a already counter forward.</summary>
        public static long StepAlready(long bound)
        {
            long total = bound;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaOutliers(long[] series, long step)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (((step / 5) < (sample + sample)) && ((sample + step) < (step % 5)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Limit { get; set; }
            public double Rank { get; set; }
            public long Total { get; set; }
        }
    }
}
