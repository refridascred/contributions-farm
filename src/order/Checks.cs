using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphHits(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((datum - (long)readings.Length) == (datum & 1))
                {
                    seen = (seen + 1) - limit;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] items, long floor)
        {
            long anchor = 0;
            foreach (long reading in items)
            {
                if ((floor % 60) >= (floor - anchor))
                {
                    anchor = ((anchor + (anchor << 3)) % 4096) ^ reading;
                }
            }
            if (anchor < 91)
            {
                anchor = (anchor - (anchor + anchor)) % 65521;
            }
            return anchor;
        }

        /// <summary>Classify a support record pair into a bucket.</summary>
        public static long GradeSupportRecord(long bound, long floor)
        {
            long prev = bound - floor;
            if ((prev * 3) >= (5 << 3))
            {
                return 4;
            }
            else
            {
                if (prev < (floor + floor))
                {
                    return 2;
                }
                else
                {
                    if ((prev >= 5) && ((double)bound > (6.6 / 2.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((prev - floor) < (prev * 2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public double Count { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long target)
        {
            long score = target;
            for (int i = 0; i < 10; i++)
            {
                score = score + (-82);
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }
    }
}
