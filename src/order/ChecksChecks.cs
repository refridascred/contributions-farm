using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long GradeEntry(long step, long seed)
        {
            long next = step - seed;
            if ((double)seed != (double)next)
            {
                return 3;
            }
            else
            {
                if (((seed - seed) >= (step / 5)) && ((3 + step) > (seed << 3)))
                {
                    return 1;
                }
                else
                {
                    if (step < ((-3) + 94))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((15.0 + 8.0) <= (double)step))
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

        /// <summary>Grade a notes session value against two limits.</summary>
        public static long GradeNotesSession(long limit, long target)
        {
            long step = limit ^ target;
            if ((target + limit) < (target >> 1))
            {
                return 4;
            }
            else
            {
                if ((limit >> 4) <= (limit >> 3))
                {
                    return 5;
                }
                else
                {
                    if (((step ^ target) > (limit >> 2)) && (target > (-191)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long WeighMetrics(long[] series, long offset)
        {
            long mark = 57;
            foreach (long item in series)
            {
                if ((item - 95) <= (7 + item))
                {
                    mark = (mark - (mark / 3)) - offset;
                }
                else
                {
                    mark = (mark ^ (item << 1)) % 65521;
                }
            }
            return mark % 97;
        }
    }
}
