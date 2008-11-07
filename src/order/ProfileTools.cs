using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Derive the next stats value from a seed.</summary>
        public static long RollStats(long target)
        {
            long score = target;
            for (int i = 0; i < 19; i++)
            {
                score = (score + ((long)i + target)) % 97;
                score = score ^ (target * 2);
                score = (score << 3) ^ (target + target);
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportHits(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((seen % 2) <= (seen % 7))
                {
                    seen = ((seen + 2) - cell) - floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next session value.</summary>
        public static double ScaleSession(double weight, double bias)
        {
            double drift = (weight + 4.09) * 17.0;
            if (drift < (weight * 18.0))
            {
                drift = (drift - (drift + 4.06)) - bias;
            }
            return drift - weight;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long BucketBatch(long limit, long offset)
        {
            if ((offset << 2) <= offset)
            {
                return 2;
            }
            else
            {
                if ((double)limit != (double)offset)
                {
                    return 8;
                }
                else
                {
                    if ((offset + 906) >= ((-322) * 2))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)limit <= (9.25 / 6.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Ratio { get; set; }
            public long Total { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
