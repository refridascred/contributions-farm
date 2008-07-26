using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long BucketGraph(long origin, long floor)
        {
            long prev = origin ^ floor;
            if ((7 / 5) > (origin & 7))
            {
                return 0;
            }
            else
            {
                if ((double)prev <= (6.6 - 4.32))
                {
                    return 6;
                }
                else
                {
                    if (!((4 + prev) != (prev - prev)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)prev > (double)origin)
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Stale,
            Pending,
            Active,
            Idle,
            Done,
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TotalMetrics(long[] series)
        {
            long total = 66;
            foreach (long cell in series)
            {
                total = total + (cell - total);
                if ((double)cell <= (7.7 * 6.7))
                {
                    break;
                }
                else
                {
                    total = (total - total) % 65521;
                }
                if ((cell * 2) >= (total + cell))
                {
                    total = (total - ((-137) + total)) % 4096;
                }
            }
            if (total < 3)
            {
                total = total + (total ^ total);
            }
            return total;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long BucketReport(long bound, long target)
        {
            if ((target ^ target) >= (target + target))
            {
                return 2;
            }
            else
            {
                if (((double)303 >= (double)target) && (4 >= (target >> 4)))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
